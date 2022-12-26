//using System;
//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using Dapper;

//namespace Asmerald.Generate.Generators
//{
//    /// <summary>
//    /// Source code generator for a SQLite database.
//    /// </summary>
//    public class SQLiteGenerator : IGenerator
//    {
//        /// <summary>
//        /// Containing configurable parts for source code generation.
//        /// </summary>
//        private readonly GenerateConfiguration _generateConfiguration;

//        /// <summary>
//        /// New SQLite generator of a database.
//        /// </summary>
//        /// <param name="config"></param>
//        public SQLiteGenerator(GenerateConfiguration config)
//        {
//            this._generateConfiguration = config;
//        }

//        /// <summary>
//        /// Generate source code.
//        /// </summary>
//        /// <returns></returns>
//        public async Task<Dictionary<string, string>> Generate()
//        {
//            return await this.Generate("");
//        }

//        public async Task<Dictionary<string, string>> Generate(string nspace)
//        {
//            using (Microsoft.Data.Sqlite.SqliteConnection sqliteConnection = new Microsoft.Data.Sqlite.SqliteConnection(this._generateConfiguration.ConnectionString))
//            {
//                var codeProvider = CodeDomProvider.CreateProvider("c#");

//                sqliteConnection.Open();

//                var tables = await sqliteConnection.QueryAsync<DatabaseSchema>("select * from sqlite_master");

//                List<TableGenerate> templateTables = new List<TableGenerate>();

//                SQLiteMapper sQLiteMapper = new SQLiteMapper();

//                foreach (var t in tables)
//                {
//                    if (t.Tbl_name == "sqlite_sequence") continue;

//                    var columns = await sqliteConnection.QueryAsync<TableSchema>("pragma table_info(" + t.Tbl_name + ")");

//                    var ctxtColumns = columns.Select(c =>
//                    {
//                        string columnType = "";
//                        // Use first the provided method to get a type
//                        if (this._generateConfiguration.ColumnTypeFunc != null)
//                        {
//                            columnType = this._generateConfiguration.ColumnTypeFunc(c.Type).Name;
//                        }
//                        // When no method was provided or no type could be determined we use the default type determination
//                        if (String.IsNullOrEmpty(columnType))
//                        {
//                            columnType = sQLiteMapper.Map(c.Type).Name;
//                        }

//                        return new TableGenerate.ColumnGenerate
//                        {
//                            Name_class = this._generateConfiguration.ColumnPrefixFunc() + codeProvider.CreateValidIdentifier(c.Name.FirstCharToUpper()),
//                            Name = c.Name,
//                            Name_method = c.Name.FirstCharToUpper(),
//                            Type = columnType
//                        };
//                    });
//                    var ctxtTable = new TableGenerate
//                    {
//                        Name_class = this._generateConfiguration.TablePrefixFunc(t) + codeProvider.CreateValidIdentifier(t.Tbl_name.FirstCharToUpper()),
//                        Name = t.Tbl_name,
//                        Columns = ctxtColumns
//                    };

//                    templateTables.Add(ctxtTable);
//                }

//                sqliteConnection.Close();

//                AsmeraldTableClassBuilder classGenerator = new AsmeraldTableClassBuilder();
//                Dictionary<string, string> dicRes = new Dictionary<string, string>();
//                foreach (var tbl in templateTables)
//                {
//                    var generatedCode = classGenerator.Build(nspace, tbl);
//                    dicRes.Add(tbl.Name_class, generatedCode);
//                }

//                return dicRes;
//            }
//        }
//    }
//}
