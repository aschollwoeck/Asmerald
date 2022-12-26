using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators.Database
{

    /// <summary>
    /// Container for database specific data used for generating necessary classes.
    /// </summary>
    public class DatabaseSchema
    {
        /// <summary>
        /// Type of the database object, e.g. table or view.
        /// </summary>
        internal string Type { get; set; } = "";
        /// <summary>
        /// Name of the database object.
        /// </summary>
        internal string Name { get; set; } = "";
        /// <summary>
        /// Name of the database object.
        /// </summary>
        internal string TableName { get; set; } = "";
        /// <summary>
        /// Sql which was used to create the database object.
        /// </summary>
        internal string Sql { get; set; } = "";
    }

    /// <summary>
    /// Container for column specific data.
    /// </summary>
    public class TableSchema
    {
        /// <summary>
        /// Internal id of column.
        /// </summary>
        public int Cid { get; set; }
        /// <summary>
        /// Name of column.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Data type of column.
        /// </summary>
        public string Type { get; set; } = "";
        /// <summary>
        /// Flag if column has to be filled with data.
        /// </summary>
        public bool Notnull { get; set; }
        /// <summary>
        /// Default value of column.
        /// </summary>
        public string DfltValue { get; set; } = string.Empty;
        /// <summary>
        /// Flag if column is a primary key.
        /// </summary>
        public int Pk { get; set; }
    }
}
