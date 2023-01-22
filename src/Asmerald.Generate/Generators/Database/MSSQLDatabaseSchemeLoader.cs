using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.X509;
using static Org.BouncyCastle.Math.Primes;
using System.Security.AccessControl;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;

namespace Asmerald.Generate.Generators.Database
{
    public class MSSQLDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public MSSQLDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new System.Data.SqlClient.SqlConnection(config.ConnectionString);
            _dbConnection.Open();
        }

        public List<DatabaseSchema> LoadTables()
        {
            return _dbConnection
                .Query<DatabaseSchema>($@"
                    SELECT 
                        TABLE_CATALOG as '{nameof(DatabaseSchema.Database)}',
                        TABLE_SCHEMA as '{nameof(DatabaseSchema.Schema)}',
                        table_type as {nameof(DatabaseSchema.Type)}, 
                        table_name as {nameof(DatabaseSchema.Name)}, 
                        table_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM INFORMATION_SCHEMA.TABLES")
                .ToList();
        }

        public List<TableSchema> LoadColumns(string table)
        {
            return _dbConnection
                .Query<TableSchema>($@"
                    SELECT 
                      ORDINAL_POSITION as {nameof(TableSchema.Cid)}, 
                      COLUMN_NAME as {nameof(TableSchema.Name)}, 
                      COLUMN_DEFAULT as {nameof(TableSchema.DfltValue)}, 
                      (CASE WHEN IS_NULLABLE = 'YES' THEN 1 ELSE 0 END) as {nameof(TableSchema.Notnull)}, 
                      DATA_TYPE as {nameof(TableSchema.Type)}
                    FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_NAME = @table
                    ",
                    new { table = table })
                .ToList();
        }

        List<StoredProcedureSchema> IDatabaseSchemeLoader.LoadStoredProcedures()
        {
            Dictionary<string, StoredProcedureSchema> res = new Dictionary<string, StoredProcedureSchema>();

            _dbConnection
                .Query<StoredProcedureSchema, StoredProcedureSchema.ParameterSchema, StoredProcedureSchema>($@"
                    SELECT 
                       SCHEMA_NAME(SCHEMA_ID) AS [{nameof(StoredProcedureSchema.Schema)}]
                      ,SO.name AS [{nameof(StoredProcedureSchema.Name)}]
                      ,P.parameter_id AS [{nameof(StoredProcedureSchema.ParameterSchema.Id)}]
                      ,P.name AS [{nameof(StoredProcedureSchema.ParameterSchema.Name)}]
                      ,TYPE_NAME(P.user_type_id) AS [{nameof(StoredProcedureSchema.ParameterSchema.Type)}]
                      ,P.max_length AS [{nameof(StoredProcedureSchema.ParameterSchema.MaxLength)}]
                      ,P.is_output AS [{nameof(StoredProcedureSchema.ParameterSchema.IsOutput)}]
                      ,P.default_value AS [{nameof(StoredProcedureSchema.ParameterSchema.DefaultValue)}]
                      ,P.is_nullable AS [{nameof(StoredProcedureSchema.ParameterSchema.IsNullable)}]
                    FROM sys.objects AS SO
                    LEFT JOIN sys.parameters AS P ON SO.OBJECT_ID = P.OBJECT_ID
                    WHERE SO.type = 'P'
                    ORDER BY [{nameof(StoredProcedureSchema.Schema)}], SO.name, P.parameter_id
                    ",
                    (sp, p) =>
                    {
                        var key = $"{sp.Schema}.{sp.Name}";
                        if (res.ContainsKey(key) == false)
                        {
                            res.Add(key, sp);
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                sp.Parameters.Add(p);
                            }
                        }
                        else
                        {
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                res[key].Parameters.Add(p);
                            }
                        }

                        return sp;
                    })
                .ToList();

            return res
                .Values
                .ToList();
        }

        List<FunctionSchema> IDatabaseSchemeLoader.LoadFunctions()
        {
            Dictionary<string, FunctionSchema> res = new Dictionary<string, FunctionSchema>();

            // Initial load of functions wiht return data type
            _dbConnection
                .Query<FunctionSchema>($@"
                    SELECT 
                        r.SPECIFIC_CATALOG as [{nameof(FunctionSchema.Database)}],
                	    r.SPECIFIC_SCHEMA as [{nameof(FunctionSchema.Schema)}],
                	    r.SPECIFIC_NAME as [{nameof(FunctionSchema.Name)}],
                	    r.DATA_TYPE as [{nameof(FunctionSchema.Type)}]
                    FROM INFORMATION_SCHEMA.ROUTINES r
                    WHERE r.ROUTINE_TYPE = 'FUNCTION' 
                    ")
                .ToList()
                .ForEach(fn => res.Add($"{fn.Schema}.{fn.Name}", fn));

            _dbConnection
                .Query<FunctionSchema, FunctionSchema.ParameterSchema, FunctionSchema>($@"
                    SELECT 
                       SCHEMA_NAME(SCHEMA_ID) AS [{nameof(FunctionSchema.Schema)}]
                      ,SO.name AS [{nameof(FunctionSchema.Name)}]
                      ,P.parameter_id AS [{nameof(FunctionSchema.ParameterSchema.Id)}]
                      ,P.name AS [{nameof(FunctionSchema.ParameterSchema.Name)}]
                      ,TYPE_NAME(P.user_type_id) AS [{nameof(FunctionSchema.ParameterSchema.Type)}]
                      ,P.max_length AS [{nameof(FunctionSchema.ParameterSchema.MaxLength)}]
                      ,P.is_output AS [{nameof(FunctionSchema.ParameterSchema.IsOutput)}]
                      ,P.default_value AS [{nameof(FunctionSchema.ParameterSchema.DefaultValue)}]
                      ,P.is_nullable AS [{nameof(FunctionSchema.ParameterSchema.IsNullable)}]
                    FROM sys.objects AS SO
                    LEFT JOIN sys.parameters AS P ON SO.OBJECT_ID = P.OBJECT_ID
                    WHERE SO.type = 'FN' And p.is_output = 'False'
                    ORDER BY [{nameof(FunctionSchema.Schema)}], SO.name, P.parameter_id
                    ",
                    (fn, p) =>
                    {
                        var key = $"{fn.Schema}.{fn.Name}";
                        if (res.ContainsKey(key) == false)
                        {
                            res.Add(key, fn);
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                fn.Parameters.Add(p);
                            }
                        }
                        else
                        {
                            if (p != null && String.IsNullOrEmpty(p.Name) == false)
                            {
                                res[key].Parameters.Add(p);
                            }
                        }

                        return fn;
                    })
                .ToList();

            return res
                .Values
                .ToList();

            // Maybe in the future use this statement but there is e.g. no "IsNullable"...
                //SELECT 
                //  r.SPECIFIC_CATALOG,
                //	r.SPECIFIC_SCHEMA,
                //	r.SPECIFIC_NAME,
                //	r.DATA_TYPE
                //	,p.ORDINAL_POSITION
                //	,p.PARAMETER_MODE
                //	,p.IS_RESULT
                //	,p.PARAMETER_NAME
                //	,p.DATA_TYPE
                //FROM INFORMATION_SCHEMA.ROUTINES r
                //LEFT JOIN INFORMATION_SCHEMA.PARAMETERS p
                //ON
                //    r.SPECIFIC_CATALOG = p.SPECIFIC_CATALOG
                //    AND r.SPECIFIC_SCHEMA = p.SPECIFIC_SCHEMA
                //    AND r.SPECIFIC_NAME = p.SPECIFIC_NAME
                //WHERE r.ROUTINE_TYPE = 'FUNCTION'
                //ORDER BY
                //   r.SPECIFIC_CATALOG
                //	,r.SPECIFIC_SCHEMA
                //	,r.SPECIFIC_NAME
                //	,p.ORDINAL_POSITION
        }

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
