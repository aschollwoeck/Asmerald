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
    public class PostgreSQLDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public PostgreSQLDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new Npgsql.NpgsqlConnection(config.ConnectionString);
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
    }
}
