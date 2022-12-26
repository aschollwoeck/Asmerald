using Asmerald.Generate.Generators.Database;
using Asmerald.Generate.Generators.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace Asmerald.Generate.Generators
{
    public class GenerateConfiguration
    {
        public DataBase DataBase { get; set; }
        public string Namespace { get; set; } = "";
        public string ConnectionString { get; set; } = "";
        public Func<DatabaseSchema, string> TablePrefixFunc { get; set; } = GetTablePrefix;
        public Func<string> ColumnPrefixFunc { get; set; } = GetColumnPrefix;
        public IDatabaseTypeMapper? CustomTypeMapper { get; set; }

        private static string GetTablePrefix(DatabaseSchema schema)
        {
            if (schema.Type.ToLowerInvariant().Contains("view"))
            {
                return "Vw";
            }

            return "Tbl";
        }

        private static string GetColumnPrefix()
        {
            return "Col_";
        }
    }
}
