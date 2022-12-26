using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace Asmerald.Generate.Generators.Mapping
{
    /// <summary>
    /// Mapping of database type to CSharp and Asmerald types.
    /// </summary>
    internal class DataBaseTypeMapping
    {
        /// <summary>
        /// Type of database column.
        /// </summary>
        public string DbType { get; set; } = "";
        /// <summary>
        /// Type which should be used in CSharp.
        /// </summary>
        public string CSharpType { get; set; } = "";
        /// <summary>
        /// Type of column which should be used in Asmerald.
        /// </summary>
        public string AsmeraldType { get; set; } = "";
    }

    /// <summary>
    /// Mapping for TinyCsvMapper library.
    /// </summary>
    internal class CsvMapping : CsvMapping<DataBaseTypeMapping>
    {
        /// <summary>
        /// Declare mapping of columns to properties.
        /// </summary>
        public CsvMapping() : base()
        {
            MapProperty(0, x => x.DbType);
            MapProperty(1, x => x.CSharpType);
            MapProperty(2, x => x.AsmeraldType);
        }
    }
}
