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
    public class OracleDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public OracleDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new OracleConnection(config.ConnectionString);
            _dbConnection.Open();
        }

        public List<DatabaseSchema> LoadTables()
        {
            return _dbConnection
                .Query<DatabaseSchema>($@"
                    SELECT 
                        'table' as {nameof(DatabaseSchema.Type)}, 
                        table_name as {nameof(DatabaseSchema.Name)}, 
                        table_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM all_tables
                    UNION
                    SELECT
                        'view' as {nameof(DatabaseSchema.Type)}, 
                        view_name as {nameof(DatabaseSchema.Name)}, 
                        view_name as {nameof(DatabaseSchema.TableName)}, 
                        '' as {nameof(DatabaseSchema.Sql)}
                    FROM all_views;")
                .ToList();
        }

        public List<TableSchema> LoadColumns(string table)
        {
            return _dbConnection
                .Query<TableSchema>($@"
                    SELECT 
                      COLUMN_ID as {nameof(TableSchema.Cid)}, 
                      COLUMN_NAME as {nameof(TableSchema.Name)}, 
                      DATA_DEFAULT as {nameof(TableSchema.DfltValue)}, 
                      NULLABLE as {nameof(TableSchema.Notnull)}, 
                      DATA_TYPE as {nameof(TableSchema.Type)}
                    FROM all_tab_columns
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
    }
}
