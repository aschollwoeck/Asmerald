using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Asmerald.Generate.Generators.SQLiteGenerator;

namespace Asmerald.Generate
{
    public class GenerateConfiguration
    {
        public string ConnectionString { get; set; } = "";
        public Func<DatabaseSchema, string> PrefixFunc { get; set; } = GetPrefix;
        public Func<string> ColPrefixFunc { get; set; } = GetColPrefix;
        public Func<string, Type>? ColumnTypeFunc { get; set; }

        private static string GetPrefix(DatabaseSchema schema)
        {
            if (schema.Type == "view")
            {
                return "Vw";
            }

            return "Tbl";
        }

        private static string GetColPrefix()
        {
            return "Col_";
        }
    }
}
