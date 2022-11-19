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
    public class SQLiteGenerator : IGenerator
    {
        public class DatabaseSchema
        {
            internal string type { get; set; }
            internal string name { get; set; }
            internal string tbl_name { get; set; }
            internal int rootpage { get; set; }
            internal string sql { get; set; }
        }

        public class TableSchema
        {
            public int cid { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public int notnull { get; set; }
            public string dflt_value { get; set; }
            public int pk { get; set; }
        }

        internal class TableGenerate
        {
            internal class ColumnGenerate
            {
                public string name_class { get; set; }
                public string name { get; set; }
                public string name_method { get; set; }
                public string type { get; set; }
            }

            public string name_class { get; set; }
            public string name { get; set; }
            public IEnumerable<ColumnGenerate> columns { get; set; } = new List<ColumnGenerate>();
        }

        private readonly GenerateConfiguration _generateConfiguration;

        public SQLiteGenerator(GenerateConfiguration config)
        {
            this._generateConfiguration = config;
        }

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

                Func<string, Type> getColumnType = this._generateConfiguration.ColumnTypeFunc;
                if(getColumnType == null)
                {
                    getColumnType = GetColumnType;
                }

                foreach (var t in tables)
                {
                    if (t.tbl_name == "sqlite_sequence") continue;

                    var columns = await sqliteConnection.QueryAsync<TableSchema>("pragma table_info(" + t.tbl_name + ")");

                    var ctxtColumns = columns.Select(c => new TableGenerate.ColumnGenerate { name_class = this._generateConfiguration.ColPrefixFunc() + codeProvider.CreateValidIdentifier(c.name.FirstCharToUpper()), name = c.name, name_method = c.name.FirstCharToUpper(), type = getColumnType(c.type).Name });
                    var ctxtTable = new TableGenerate { name_class = this._generateConfiguration.PrefixFunc(t) + codeProvider.CreateValidIdentifier(t.tbl_name.FirstCharToUpper()), name = t.tbl_name, columns = ctxtColumns };

                    templateTables.Add(ctxtTable);
                }

                sqliteConnection.Close();


                Dictionary<string, string> dicRes = new Dictionary<string, string>();
                foreach (var tbl in templateTables)
                {
                    var generatedCode = BuildCode(nspace, tbl);
                    dicRes.Add(tbl.name_class, generatedCode);
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

            w.Write($"public class {table.name_class} : ITable");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine($"string ITable.Name() => \"{table.name}\";");

            foreach (var column in table.columns)
            {
                w.WriteLine($"public static {column.name_class} {column.name_method}() => new {column.name_class}();");
                w.WriteLine($"public static {column.name_class} {column.name_method}(string tableAlias) => new {column.name_class}(tableAlias);");
            }

            foreach (var column in table.columns)
            {
                w.WriteLine($"public class {column.name_class} : {column.type}<{table.name_class}>, ISelectColumn<{table.name_class}>, ISelectColumnAlias<{table.name_class}>");
                w.WriteLine("{");
                w.Indent++;

                w.WriteLine($"private readonly string _name = \"{column.name}\";");
                w.WriteLine($"string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"readonly string? TableAlias;");
                w.WriteLine($"public {column.name_class}() {{ }}");
                w.WriteLine($"public {column.name_class}(string tableAlias) {{ this.TableAlias = tableAlias; }}");
                w.WriteLine($"public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"public override ISelectColumnAlias<{table.name_class}> As(string name) => new AliasColumn<{table.name_class}>(this, name);");
                w.WriteLine($"public override ISelectColumn<{table.name_class}> Count() => new CountColumn<{table.name_class}>(this);");

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
