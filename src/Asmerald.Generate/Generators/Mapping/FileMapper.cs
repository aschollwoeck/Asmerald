﻿using System;
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

        private readonly List<DataBaseTypeMapping> _mappings;

        public FileMapper(string filePath)
        {
            var csvParser = new CsvParser<DataBaseTypeMapping>(
                new CsvParserOptions(false, CSV_SPLIT_CHAR),
                new CsvMapping());

            _mappings = csvParser
                .ReadFromFile(filePath, Encoding.Unicode)
                .Select(p => p.Result)
                .ToList();
        }

        public Type? Map(string dbColumnType)
        {
            var t = _mappings.FirstOrDefault(r => r.DbType == dbColumnType);
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
