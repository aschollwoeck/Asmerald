using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators.Mapping
{
    public class SQLiteMapper : IDatabaseTypeMapper
    {
        public Type? Map(string dbColumnType)
        {
            // https://www.sqlite.org/datatype3.html
            if (dbColumnType.Contains("INT")) return typeof(Columns.IntegerColumn);
            if (dbColumnType.ContainsOneOf(new[] { "CHAR", "CLOB", "TEXT" })) return typeof(Columns.StringColumn);
            if (dbColumnType.Contains("BLOB")) return typeof(Columns.ByteArrColumn);
            if (dbColumnType.ContainsOneOf(new[] { "REAL", "FLOA", "DOUB" })) return typeof(Columns.DecimalColumn);

            return typeof(Columns.DecimalColumn);
        }
    }
}
