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
                        table_type as {nameof(DatabaseSchema.Type)}, 
                        table_name as {nameof(DatabaseSchema.Name)}, 
                        table_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM INFORMATION_SCHEMA.TABLES;")
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
                    WHERE TABLE_NAME = @table;
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
                    FROM sys.objects AS [SO
                    LEFT JOIN sys.parameters AS [P ON SO.OBJECT_ID = P.OBJECT_ID
                    WHERE SO.type = 'P'
                    ORDER BY [{nameof(StoredProcedureSchema.Schema)}], SO.name, P.parameter_id
                    ",
                    (sp, p) =>
                    {
                        if (p != null && String.IsNullOrEmpty(p.Name))
                        {
                            sp.Parameters.Add(p);
                        }
                        var key = $"{sp.Schema}.{sp.Name}";
                        if (res.ContainsKey(key) == false)
                        {
                            res.Add(key, sp);
                        }
                        else
                        {
                            if (p != null && String.IsNullOrEmpty(p.Name))
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

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
