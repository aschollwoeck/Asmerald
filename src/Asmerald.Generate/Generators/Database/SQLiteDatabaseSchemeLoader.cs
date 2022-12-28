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

        public List<StoredProcedureSchema> LoadStoredProcedures()
        {
            Dictionary<string, StoredProcedureSchema> res = new Dictionary<string, StoredProcedureSchema>();

            _dbConnection
                .Query<StoredProcedureSchema, StoredProcedureSchema.ParameterSchema, StoredProcedureSchema>($@"
                    SELECT 
                       SCHEMA AS [{nameof(StoredProcedureSchema.Schema)}]
                      ,SO.name AS [{nameof(StoredProcedureSchema.Name)}]
                      ,P.parameter_id AS [{nameof(StoredProcedureSchema.ParameterSchema.Id)}]
                      ,P.name AS [{nameof(StoredProcedureSchema.ParameterSchema.Name)}]
                      ,TYPE_NAME AS [{nameof(StoredProcedureSchema.ParameterSchema.Type)}]
                      ,P.max_length AS [{nameof(StoredProcedureSchema.ParameterSchema.MaxLength)}]
                      ,P.is_output AS [{nameof(StoredProcedureSchema.ParameterSchema.IsOutput)}]
                      ,P.default_value AS [{nameof(StoredProcedureSchema.ParameterSchema.DefaultValue)}]
                      ,P.is_nullable AS [{nameof(StoredProcedureSchema.ParameterSchema.IsNullable)}]
                    FROM 'sys.objects' AS SO
                    LEFT JOIN 'sys.parameters' AS P ON SO.OBJECT_ID = P.OBJECT_ID
                    WHERE SO.type = 'P'
                    ORDER BY [{nameof(StoredProcedureSchema.Schema)}], SO.name, P.parameter_id
                    ",
                    (sp, p) =>
                    {
                        if (p != null && String.IsNullOrEmpty(p.Name) == false)
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

        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }
    }
}
