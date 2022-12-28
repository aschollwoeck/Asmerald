using Asmerald.Generate.Generators.Database;
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
        /// Schema in which table lives in (also called "database").
        /// </summary>
        public string Schema { get; set; } = "";
        /// <summary>
        /// Name of table.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Class name of procedure.
        /// </summary>
        public string Name_class { get; set; } = "";
        /// <summary>
        /// Columns of table.
        /// </summary>
        public IEnumerable<ColumnGenerate> Columns { get; set; } = new List<ColumnGenerate>();
    }

    /// <summary>
    /// Class used for generating source code representing a stored procedure.
    /// </summary>
    public class StoredProcedureGenerate
    {
        /// <summary>
        /// Class used for generating source for a paramter of a stored procedure.
        /// </summary>
        public class ParameterGenerate
        {
            /// <summary>
            /// Data from database.
            /// </summary>
            private readonly StoredProcedureSchema.ParameterSchema _parameterSchema;
            /// <summary>
            /// Name of parameter.
            /// </summary>
            public string Name { get; set; } = "";
            /// <summary>
            /// Name of parameter in source code.
            /// </summary>
            public string Name_class { get; set; } = "";
            /// <summary>
            /// Data type of parameter.
            /// </summary>
            public string Type { get; set; } = "";
            /// <summary>
            /// Determines wether the parameter is also used for output.
            /// </summary>
            public bool IsOutput { get; set; }
            /// <summary>
            /// Default value of parameter.
            /// </summary>
            public string DefaultValue { get; set; } = "";
            /// <summary>
            /// Identifier if parameter can be null.
            /// </summary>
            public bool IsNullable { get; set; }

            /// <summary>
            /// Create a new object with reference to parameter from database.
            /// </summary>
            /// <param name="parameterSchema"></param>
            public ParameterGenerate(StoredProcedureSchema.ParameterSchema parameterSchema)
            {
                this._parameterSchema = parameterSchema;
            }

            public override string ToString()
            {
                if (!String.IsNullOrEmpty(Name))
                {
                    return $"{Name} {Type} IsOutput: {IsOutput}";
                }

                return base.ToString();
            }
        }

        private readonly StoredProcedureSchema _storedProcedureSchema;
        /// <summary>
        /// Schema or database where stored procedure lives in.
        /// </summary>
        public string Schema { get; set; } = "";
        /// <summary>
        /// Name of stored procedure.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Name of stored procedure in source code.
        /// </summary>
        public string Name_class { get; set; } = "";
        /// <summary>
        /// Parameters of stored procedure.
        /// </summary>
        public List<ParameterGenerate> Parameters { get; set; } = new List<ParameterGenerate>();

        /// <summary>
        /// Creates a new stored procedure object with reference to database data.
        /// </summary>
        /// <param name="storedProcedureSchema"></param>
        public StoredProcedureGenerate(StoredProcedureSchema storedProcedureSchema)
        {
            this._storedProcedureSchema = storedProcedureSchema;
        }

        public override string ToString()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return $"{Name} | Parameters: {Parameters.Count}";
            }

            return base.ToString();
        }
    }
}
