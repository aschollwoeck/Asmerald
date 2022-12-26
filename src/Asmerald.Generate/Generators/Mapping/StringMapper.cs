using Asmerald.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;

namespace Asmerald.Generate.Generators.Mapping
{
    public class StringMapper : IDatabaseTypeMapper
    {
        private const char CSV_SPLIT_CHAR = ';';

        private readonly List<DataBaseTypeMapping> _mappings;

        public StringMapper(string csv)
        {
            var options = new CsvParserOptions(false, CSV_SPLIT_CHAR);

            var csvParser = new CsvParser<DataBaseTypeMapping>(
                options,
                new CsvMapping());

            _mappings = csvParser
                .ReadFromString(new CsvReaderOptions(new[] { Environment.NewLine }), csv)
                .Select(p => p.Result)
                .ToList();
        }

        public Type? Map(string dbColumnType)
        {
            var t = _mappings.FirstOrDefault(r => r.DbType.ToLowerInvariant() == dbColumnType.ToLowerInvariant());
            if (t != null)
            {
                var tr = typeof(StringColumn).Assembly.GetType("Asmerald.Columns." + t.AsmeraldType);
                if (tr == null)
                {
                    throw new Exception($"Asmerald column data type '{dbColumnType}' not found in assembly! Missing namespace?");
                }
                return tr;
            }

            return null;
        }
    }
}
