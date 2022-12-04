using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TypeProofSql.Generate.Generators
{
    /// <summary>
    /// Source code generator for a SQLite database.
    /// </summary>
    public class SQLiteGenerator : IGenerator
    {
        /// <summary>
        /// Container for database specific data used for generating necessary classes.
        /// </summary>
        public class DatabaseSchema
        {
            /// <summary>
            /// Type of the database object, e.g. table or view.
            /// </summary>
            internal string Type { get; set; }
            /// <summary>
            /// Name of the database object.
            /// </summary>
            internal string Name { get; set; }
            /// <summary>
            /// Name of the database object.
            /// </summary>
            internal string Tbl_name { get; set; }
            /// <summary>
            /// Root of database schema.
            /// </summary>
            internal int Rootpage { get; set; }
            /// <summary>
            /// Sql which was used to create the database object.
            /// </summary>
            internal string Sql { get; set; }
        }

        /// <summary>
        /// Container for column specific data.
        /// </summary>
        public class TableSchema
        {
            /// <summary>
            /// Internal id of column.
            /// </summary>
            public int Cid { get; set; }
            /// <summary>
            /// Name of column.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Data type of column.
            /// </summary>
            public string Type { get; set; }
            /// <summary>
            /// Flag if column has to be filled with data.
            /// </summary>
            public int Notnull { get; set; }
            /// <summary>
            /// Default value of column.
            /// </summary>
            public string DfltValue { get; set; }
            /// <summary>
            /// Flag if column is a primary key.
            /// </summary>
            public int Pk { get; set; }
        }

        /// <summary>
        /// Class used for generating source code presenting necessary data for a table.
        /// </summary>
        internal class TableGenerate
        {
            /// <summary>
            /// Class used for generating source code representing necessary data for a column.
            /// </summary>
            internal class ColumnGenerate
            {
                /// <summary>
                /// Class name of column.
                /// </summary>
                public string Name_class { get; set; }
                /// <summary>
                /// Name of column.
                /// </summary>
                public string Name { get; set; }
                /// <summary>
                /// Method name of column.
                /// </summary>
                public string Name_method { get; set; }
                /// <summary>
                /// Data type of column.
                /// </summary>
                public string Type { get; set; }
            }

            /// <summary>
            /// Class name of table.
            /// </summary>
            public string Name_class { get; set; }
            /// <summary>
            /// Name of table.
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// Columns of table.
            /// </summary>
            public IEnumerable<ColumnGenerate> Columns { get; set; } = new List<ColumnGenerate>();
        }

        /// <summary>
        /// Containing configurable parts for source code generation.
        /// </summary>
        private readonly GenerateConfiguration _generateConfiguration;

        /// <summary>
        /// New SQLite generator of a database.
        /// </summary>
        /// <param name="config"></param>
        public SQLiteGenerator(GenerateConfiguration config)
        {
            this._generateConfiguration = config;
        }

        /// <summary>
        /// Generate source code.
        /// </summary>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> Generate()
        {
            return await this.Generate("");
        }

        public async Task<Dictionary<string, string>> Generate(string nspace)
        {
            using (Microsoft.Data.Sqlite.SqliteConnection sqliteConnection = new Microsoft.Data.Sqlite.SqliteConnection(this._generateConfiguration.ConnectionString))
            {
                var codeProvider = CodeDomProvider.CreateProvider("c#");

                sqliteConnection.Open();

                var tables = await sqliteConnection.QueryAsync<DatabaseSchema>("select * from sqlite_master");

                List<TableGenerate> templateTables = new List<TableGenerate>();

                Func<string, Type>? getColumnType = this._generateConfiguration.ColumnTypeFunc;
                if(getColumnType == null)
                {
                    getColumnType = GetColumnType;
                }

                foreach (var t in tables)
                {
                    if (t.Tbl_name == "sqlite_sequence") continue;

                    var columns = await sqliteConnection.QueryAsync<TableSchema>("pragma table_info(" + t.Tbl_name + ")");

                    var ctxtColumns = columns.Select(c => new TableGenerate.ColumnGenerate
                    {
                        Name_class = this._generateConfiguration.ColPrefixFunc() + codeProvider.CreateValidIdentifier(c.Name.FirstCharToUpper()),
                        Name = c.Name,
                        Name_method = c.Name.FirstCharToUpper(),
                        Type = getColumnType(c.Type).Name
                    });
                    var ctxtTable = new TableGenerate
                    {
                        Name_class = this._generateConfiguration.PrefixFunc(t) + codeProvider.CreateValidIdentifier(t.Tbl_name.FirstCharToUpper()),
                        Name = t.Tbl_name,
                        Columns = ctxtColumns
                    };

                    templateTables.Add(ctxtTable);
                }

                sqliteConnection.Close();


                Dictionary<string, string> dicRes = new Dictionary<string, string>();
                foreach (var tbl in templateTables)
                {
                    var generatedCode = BuildCode(nspace, tbl);
                    dicRes.Add(tbl.Name_class, generatedCode);
                }

                return dicRes;
            }
        }

        private string BuildCode(string nspace, TableGenerate table)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using System;");
            w.WriteLine("using TypeProofSql;");
            w.WriteLine("using TypeProofSql.Columns;");
            w.WriteLine();

            if(String.IsNullOrEmpty(nspace) == false)
            {
                w.WriteLine($"namespace {nspace}");
                w.WriteLine("{");
                w.Indent++;
            }

            w.Write($"public class {table.Name_class} : ITable");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine($"string ITable.Name() => \"{table.Name}\";");

            foreach (var column in table.Columns)
            {
                w.WriteLine($"public static {column.Name_class} {column.Name_method}() => new {column.Name_class}();");
                w.WriteLine($"public static {column.Name_class} {column.Name_method}(string tableAlias) => new {column.Name_class}(tableAlias);");
            }

            foreach (var column in table.Columns)
            {
                w.WriteLine($"public class {column.Name_class} : {column.Type}<{table.Name_class}>, ISelectColumn<{table.Name_class}>, ISelectColumnAlias<{table.Name_class}>");
                w.WriteLine("{");
                w.Indent++;

                w.WriteLine($"private readonly string _name = \"{column.Name}\";");
                w.WriteLine($"string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"readonly string? TableAlias;");
                w.WriteLine($"public {column.Name_class}() {{ }}");
                w.WriteLine($"public {column.Name_class}(string tableAlias) {{ this.TableAlias = tableAlias; }}");
                w.WriteLine($"public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"public override ISelectColumnAlias<{table.Name_class}> As(string name) => new AliasColumn<{table.Name_class}>(this, name);");
                w.WriteLine($"public override ISelectColumn<{table.Name_class}> Count() => new CountColumn<{table.Name_class}>(this);");

                w.Indent--;
                w.WriteLine("}");
            }

            w.Indent--;
            w.WriteLine("}");

            if (String.IsNullOrEmpty(nspace) == false)
            {
                w.Indent--;
                w.WriteLine("}");
            }

            w.Flush();
            return sw.ToString();
        }

        private Type GetColumnType(string columnDataType)
        {
            // https://www.sqlite.org/datatype3.html

            if (columnDataType.Contains("INT")) return typeof(TypeProofSql.Columns.IntegerColumn);
            if (columnDataType.ContainsOneOf(new[] { "CHAR", "CLOB", "TEXT" })) return typeof(TypeProofSql.Columns.StringColumn);
            if (columnDataType.Contains("BLOB")) return typeof(TypeProofSql.Columns.BlobColumn);
            if (columnDataType.ContainsOneOf(new[] { "REAL", "FLOA", "DOUB" })) return typeof(TypeProofSql.Columns.DecimalColumn);

            return typeof(TypeProofSql.Columns.DecimalColumn);
        }
    }
}
