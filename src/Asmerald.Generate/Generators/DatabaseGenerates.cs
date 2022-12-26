using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators
{
    /// <summary>
    /// Class used for generating source code presenting necessary data for a table.
    /// </summary>
    public class TableGenerate
    {
        /// <summary>
        /// Class used for generating source code representing necessary data for a column.
        /// </summary>
        public class ColumnGenerate
        {
            /// <summary>
            /// Name of column.
            /// </summary>
            public string DbName { get; set; } = "";
            /// <summary>
            /// Data type of column.
            /// </summary>
            public string DbType { get; set; } = "";
            /// <summary>
            /// Class name of column.
            /// </summary>
            public string Name_class { get; set; } = "";
            /// <summary>
            /// Name of column.
            /// </summary>
            public string Name { get; set; } = "";
            /// <summary>
            /// Method name of column.
            /// </summary>
            public string Name_method { get; set; } = "";
            /// <summary>
            /// Data type of column.
            /// </summary>
            public string Type { get; set; } = "";
        }

        /// <summary>
        /// Name of table.
        /// </summary>
        public string DbName { get; set; } = "";
        /// <summary>
        /// Type of table (table, view...).
        /// </summary>
        public string DbType { get; set; } = "";
        /// <summary>
        /// Name of table.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Class name of table.
        /// </summary>
        public string Name_class { get; set; } = "";
        /// <summary>
        /// Columns of table.
        /// </summary>
        public IEnumerable<ColumnGenerate> Columns { get; set; } = new List<ColumnGenerate>();
    }
}
