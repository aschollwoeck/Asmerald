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
        /// Database where table is in.
        /// </summary>
        public string Database { get; set; } = "";
        /// <summary>
        /// Schema where table is in.
        /// </summary>
        public string Schema { get; set; } = "";
        /// <summary>
        /// Type of the database object, e.g. table or view.
        /// </summary>
        public string Type { get; set; } = "";
        /// <summary>
        /// Name of the database object.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Name of the database object.
        /// </summary>
        public string TableName { get; set; } = "";
        /// <summary>
        /// Sql which was used to create the database object.
        /// </summary>
        public string Sql { get; set; } = "";
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

    public class StoredProcedureSchema
    {
        public class ParameterSchema
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public int MaxLength { get; set; }
            public bool IsOutput { get; set; }
            public string DefaultValue { get; set; } = "";
            public bool IsNullable { get; set; }

            public override string ToString()
            {
                if(!String.IsNullOrEmpty(Name))
                {
                    return $"{Name} {Type} IsOutput: {IsOutput}";
                }

                return base.ToString();
            }
        }

        public string Name { get; set; } = "";
        public string Database { get; set; } = "";
        public string Schema { get; set; } = "";
        public List<ParameterSchema> Parameters { get; set; } = new List<ParameterSchema>();

        public override string ToString()
        {
            if(!String.IsNullOrEmpty(Name))
            {
                return $"{Schema}.{Name} | Parameters: {Parameters.Count}";
            }

            return base.ToString();
        }
    }

    public class FunctionSchema
    {
        public class ParameterSchema
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Type { get; set; } = "";
            public int MaxLength { get; set; }
            public bool IsOutput { get; set; }
            public string DefaultValue { get; set; } = "";
            public bool IsNullable { get; set; }

            public override string ToString()
            {
                if (!String.IsNullOrEmpty(Name))
                {
                    return $"{Name} {Type} IsOutput: {IsOutput}";
                }

                return base.ToString();
            }
        }

        public string Name { get; set; } = "";
        public string Database { get; set; } = "";
        public string Schema { get; set; } = "";
        public string Type { get; set; } = "";
        public List<ParameterSchema> Parameters { get; set; } = new List<ParameterSchema>();

        public override string ToString()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return $"{Schema}.{Name} | Parameters: {Parameters.Count}";
            }

            return base.ToString();
        }
    }
}
