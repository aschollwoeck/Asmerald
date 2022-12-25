using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace Asmerald.Generate.Generators
{
    /// <summary>
    /// Source code generator for a Postgres database.
    /// </summary>
    internal class OracleGenerator : IGenerator
    {
        public Task<Dictionary<string, string>> Generate()
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, string>> Generate(string nspace)
        {
            throw new NotImplementedException();
        }

        private Type GetColumnType(string columnDataType)
        {
            // https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/oracle-data-type-mappings

            var csvParser = new TinyCsvParser.CsvParser<DataBaseTypeMapping>(
                new TinyCsvParser.CsvParserOptions(false, ';'),
                new CsvMapping());

            var results = csvParser
                .ReadFromFile("oracle_type_mapping.csv", Encoding.Unicode)
                .Select(p => p.Result)
                .ToList();

            var t = results.FirstOrDefault(r => r.DbType == columnDataType);
            if(t != null)
            {
                var tr = Type.GetType(t.AsmeraldType);
                if (tr == null)
                {
                    throw new Exception($"Asmerald column data type '{columnDataType}' not found in assembly! Missing namespace?");
                }
                return tr;
            }

            throw new Exception($"Oracle column data type '{columnDataType}' not supported in Asmerald! Please provide your own type mapping.");
        }
    }
}
