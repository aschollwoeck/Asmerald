using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;

namespace Asmerald.Generate.Generators.Mapping
{
    public class FileMapper : IDatabaseTypeMapper
    {
        private const char CSV_SPLIT_CHAR = ';';

        private readonly string _filePath;

        public FileMapper(string filePath)
        {
            _filePath = filePath;
        }

        public Type? Map(string dbColumnType)
        {
            var csvParser = new CsvParser<DataBaseTypeMapping>(
                new CsvParserOptions(false, CSV_SPLIT_CHAR),
                new CsvMapping());

            var results = csvParser
                .ReadFromFile(_filePath, Encoding.Unicode)
                .Select(p => p.Result)
                .ToList();

            var t = results.FirstOrDefault(r => r.DbType == dbColumnType);
            if (t != null)
            {
                var tr = Type.GetType(t.AsmeraldType);
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
