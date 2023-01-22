using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static Asmerald.Generate.Generators.Database.MSSQLDatabaseSchemeLoader;

namespace Asmerald.Generate.Generators.Database
{
    public class SQLiteDatabaseSchemeLoader : IDatabaseSchemeLoader, IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public SQLiteDatabaseSchemeLoader(GenerateConfiguration config)
        {
            _dbConnection = new SqliteConnection(config.ConnectionString);
            _dbConnection.Open();
        }

        public List<DatabaseSchema> LoadTables()
        {
            return _dbConnection
                .Query<DatabaseSchema>(@"
                    SELECT type, name, tbl_name as tablename, sql 
                    FROM sqlite_master 
                    WHERE tbl_name != 'sqlite_sequence'")
                .ToList();
        }

        public List<TableSchema> LoadColumns(string table)
        {
            return _dbConnection
                .Query<TableSchema>("pragma table_info('" + table + "')")
                .ToList();
        }

        public List<FunctionSchema> LoadFunctions()
        {
            Dictionary<string, FunctionSchema> res = new Dictionary<string, FunctionSchema>();

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

        public List<StoredProcedureSchema> LoadStoredProcedures()
        {
            // There are no stored procedures in SQLite
            return new List<StoredProcedureSchema>();
        }
    }
}
