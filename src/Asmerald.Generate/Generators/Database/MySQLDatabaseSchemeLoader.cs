using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oracle.ManagedDataAccess.Client;

namespace Asmerald.Generate.Generators.Database
{
    public class MySQLDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public MySQLDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new MySql.Data.MySqlClient.MySqlConnection(config.ConnectionString);
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

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }

        public List<StoredProcedureSchema> LoadStoredProcedures()
        {
            Dictionary<string, StoredProcedureSchema> res = new Dictionary<string, StoredProcedureSchema>();

            _dbConnection
                .Query<StoredProcedureSchema, StoredProcedureSchema.ParameterSchema, StoredProcedureSchema>($@"

                    select     
                        so.routine_schema as '{{nameof(StoredProcedureSchema.Schema)',
                        so.routine_name as '{nameof(StoredProcedureSchema.Name)}',
                        p.ordinal_position as {nameof(StoredProcedureSchema.ParameterSchema.Id)},
                        p.parameter_name as {nameof(StoredProcedureSchema.ParameterSchema.Name)},
                        p.parameter_mode as 'Mode',
                        0 as {nameof(StoredProcedureSchema.ParameterSchema.IsOutput)},
                        p.data_type as {nameof(StoredProcedureSchema.ParameterSchema.MaxLength)},
                        p.character_maximum_length as {nameof(StoredProcedureSchema.ParameterSchema.MaxLength)},
                        null as {nameof(StoredProcedureSchema.ParameterSchema.DefaultValue)},
                        0 as {nameof(StoredProcedureSchema.ParameterSchema.IsNullable)}
                    from information_schema.routines as so
                    left join information_schema.parameters as p ON so.specific_name = p.specific_name
                    WHERE 
                        so.routine_type = 'PROCEDURE'
                    ORDER BY so.routine_schema, so.routine_name, p.ordinal_position;
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
    }
}
