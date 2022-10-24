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
        internal class DatabaseSchema
        {
            internal string type { get; set; }
            internal string name { get; set; }
            internal string tbl_name { get; set; }
            internal int rootpage { get; set; }
            internal string sql { get; set; }
        }

        internal class TableSchema
        {
            public int cid { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public int notnull { get; set; }
            public string dflt_value { get; set; }
            public int pk { get; set; }
        }

        private readonly string _connectionString;

        public SQLiteGenerator(string connectionString)
        {
            this._connectionString = connectionString;
        }

        public async Task<Dictionary<string, string>> Generate()
        {
            return await this.Generate("");
        }

        public async Task<Dictionary<string, string>> Generate(string nspace)
        {
            using (Microsoft.Data.Sqlite.SqliteConnection sqliteConnection = new Microsoft.Data.Sqlite.SqliteConnection(this._connectionString))
            {
                var codeProvider = CodeDomProvider.CreateProvider("c#");

                sqliteConnection.Open();

                var tables = await sqliteConnection.QueryAsync<DatabaseSchema>("select * from sqlite_master");

                List<dynamic> templateTables = new List<dynamic>();

                foreach (var t in tables)
                {
                    if (t.tbl_name == "sqlite_sequence") continue;

                    var columns = await sqliteConnection.QueryAsync<TableSchema>("pragma table_info(" + t.tbl_name + ")");

                    var ctxtColumns = columns.Select(c => new { name_class = "Col_" + codeProvider.CreateValidIdentifier(c.name.FirstCharToUpper()), name = c.name, name_method = c.name.FirstCharToUpper(), type = GetColumnType(c.type).Name });
                    var ctxtTable = new { name_class = GetPrefix(t) + codeProvider.CreateValidIdentifier(t.tbl_name.FirstCharToUpper()), name = t.tbl_name, columns = ctxtColumns };

                    templateTables.Add(ctxtTable);
                }

                sqliteConnection.Close();

                var template = this.ReadResource("classGeneration.txt");
                var templateParsed = Scriban.Template.ParseLiquid(template);

                Dictionary<string, string> dicRes = new Dictionary<string, string>();
                foreach (var tbl in templateTables)
                {
                    var generatedCode = await templateParsed.RenderAsync(new { nspace = nspace, tables = templateTables });
                    dicRes.Add(tbl.name_class, generatedCode);
                }

                return dicRes;
            }
        }

        private string GetPrefix(DatabaseSchema schema)
        {
            if (schema.type == "view")
            {
                return "Vw";
            }

            return "Tbl";
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

        public string ReadResource(string name)
        {
            // Determine path
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = name;
            // Format: "{Namespace}.{Folder}.{filename}.{Extension}"
            if (!name.StartsWith(nameof(TypeProofSql)))
            {
                resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(name));
            }

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
