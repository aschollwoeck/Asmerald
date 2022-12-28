using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Asmerald.Columns;
using Asmerald.Generate.Generators.Database;
using Asmerald.Generate.Generators.Mapping;
using Dapper;

namespace Asmerald.Generate.Generators
{
    /// <summary>
    /// Source code generator for a SQLite database.
    /// </summary>
    public class AsmeraldGenerator : IGenerator
    {
        /// <summary>
        /// Containing configurable parts for source code generation.
        /// </summary>
        private readonly GenerateConfiguration _generateConfiguration;

        /// <summary>
        /// Map type of database column to Asmerald column type.
        /// </summary>
        private readonly IDatabaseTypeMapper _databaseTypeMapper;

        /// <summary>
        /// Loads necessary informations from database.
        /// </summary>
        private readonly IDatabaseSchemeLoader _databaseSchemeLoader;

        /// <summary>
        /// New SQLite generator of a database.
        /// </summary>
        /// <param name="config"></param>
        public AsmeraldGenerator(GenerateConfiguration config, IDatabaseSchemeLoader databaseSchemeLoader, IDatabaseTypeMapper databaseTypeMapper)
        {
            this._generateConfiguration = config;
            this._databaseTypeMapper = databaseTypeMapper;
            this._databaseSchemeLoader = databaseSchemeLoader;
        }

        /// <summary>
        /// Generate source code.
        /// </summary>
        /// <returns></returns>
        public (List<TableGenerate>, List<StoredProcedureGenerate>) Generate()
        {
            var codeProvider = CodeDomProvider.CreateProvider("c#");

            // Load tables
            var tables = this._databaseSchemeLoader.LoadTables();

            List<TableGenerate> templateTables = new List<TableGenerate>();
            foreach (var t in tables)
            {
                // Load columns
                var columns = this._databaseSchemeLoader.LoadColumns(t.TableName);

                var ctxtColumns = columns.Select(c =>
                {
                    Type? columnType = null;
                    // Use first the provided method to get a type
                    if (this._generateConfiguration.CustomTypeMapper != null)
                    {
                        columnType = this._generateConfiguration.CustomTypeMapper.Map(c.Type);
                    }
                    // When no method was provided or no type could be determined we use the default type determination
                    if (columnType == null)
                    {
                        columnType = this._databaseTypeMapper.Map(c.Type);
                    }
                    if(columnType == null)
                    {
                        throw new Exception($"{this._generateConfiguration.DataBase} column data type '{c.Type}' not supported in Asmerald! Please provide your own type mapping.");
                    }

                    return new TableGenerate.ColumnGenerate
                    {
                        DbName = c.Name,
                        DbType = c.Type,
                        Name_class = this._generateConfiguration.ColumnPrefixFunc() + codeProvider.CreateValidIdentifier(c.Name.FirstCharToUpper()),
                        Name = c.Name,
                        Name_method = c.Name.FirstCharToUpper(),
                        Type = columnType.Name
                    };
                });

                var ctxtTable = new TableGenerate
                {
                    DbName = t.Name,
                    DbType = t.Type,
                    Name_class = this._generateConfiguration.TablePrefixFunc(t) + codeProvider.CreateValidIdentifier(t.TableName.FirstCharToUpper()),
                    Name = t.TableName,
                    Columns = ctxtColumns
                };

                templateTables.Add(ctxtTable);
            }

            List<StoredProcedureGenerate> templateSPs = new List<StoredProcedureGenerate>();
            var sps = this._databaseSchemeLoader.LoadStoredProcedures();
            foreach (var sp in sps)
            {
                StoredProcedureGenerate sgGen = new StoredProcedureGenerate(sp)
                {
                    Name = sp.Name,
                    Name_class = codeProvider.CreateValidIdentifier($"StProc_{sp.Name}"),
                    Schema = sp.Schema
                };

                foreach (var para in sp.Parameters)
                {
                    sgGen.Parameters.Add(new StoredProcedureGenerate.ParameterGenerate(para)
                    {
                        Name = para.Name,
                        Name_class = codeProvider.CreateValidIdentifier(para.Name.FirstCharToUpper()),
                        DefaultValue = para.DefaultValue,
                        IsNullable = para.IsNullable,
                        IsOutput = para.IsOutput,
                        Type = GetTypeFromColumn(this._databaseTypeMapper.Map(para.Type).Name).FullName
                    });
                }

                templateSPs.Add(sgGen);
            }

            return (templateTables, templateSPs);
        }

        private Type GetTypeFromColumn(string column)
        {
            var ass = typeof(LongColumn<>).Assembly;

            // We want the generic form of the column type - this is indicated with `1
            var genClass = ass.GetType($"{nameof(Asmerald)}.{nameof(Asmerald.Columns)}.{column}`1");

            if(genClass == null)
            {
                throw new Exception($"Type '{nameof(Asmerald)}.{nameof(Asmerald.Columns)}.{column}`1' not found in Assembly of Asmerald!");
            }

            // From this type we get then the actual type
            var columnType = genClass.GetInterface("IColumn`2");

            if(columnType == null)
            {
                throw new Exception($"Generic 'IColumn' interface not found for type '{nameof(Asmerald)}.{nameof(Asmerald.Columns)}.{column}`1'");
            }

            // First argument is the type
            var t = columnType.GetGenericArguments().First();

            return t;
        }
    }
}
