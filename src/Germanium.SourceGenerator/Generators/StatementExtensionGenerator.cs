using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Germanium.SourceGenerator.Generators
{
    internal class StatementExtensionGenerator
    {
        internal string Generate(GenerateExtensionCodeStatement generateExtension)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using System;");
            w.WriteLine("using System.Collections.Generic;");
            w.WriteLine("using System.Linq;");
            //w.WriteLine("using System.Text;");
            w.WriteLine("using TypeProofSql.Columns;");
            w.WriteLine("using TypeProofSql.Expressions;");
            w.WriteLine("using TypeProofSql.QueryBuilders;");
            w.WriteLine("using TypeProofSql.Statements;");
            w.WriteLine($"using TypeProofSql.Statements.{generateExtension.nspace};");
            w.WriteLine();
            w.WriteLine($"namespace TypeProofSql.{generateExtension.nspace}");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine($"public static partial class TypeProofSql{generateExtension.extension_name}Extensions");
            w.WriteLine("{");
            w.Indent++;

            foreach (var ext in generateExtension.extensions)
            {
                w.Write($"public static {ext.return_class_name.full_class_name} {generateExtension.extension_name}");

                if (ext.generic_types != null && ext.generic_types.Count > 0)
                {
                    w.Write($"<{String.Join(", ", ext.generic_types)}>");
                }
                w.Write($"(this {ext.base_class.class_name}");

                if(ext.base_class.generics != null && ext.base_class.generics.Count > 0)
                {
                    w.Write("<");
                    w.Write(String.Join(", ", ext.base_class.generics));
                    w.Write(">");
                }

                w.Write(" stmt");

                foreach (var prop in ext.return_class_name.properties)
                {
                    w.Write(", ");
                    if (prop.is_list)
                    {
                        w.Write($"params {prop.class_name}[]");
                    }
                    else
                    {
                        w.Write(prop.class_name);
                    }
                    w.Write($" {prop.para}");
                }
                w.WriteLine(")");

                w.Indent++;
                if (ext.generic_types != null)
                {
                    foreach (var gentyp in ext.generic_types)
                    {
                        w.WriteLine($"where {gentyp} : ITable, new()");
                    }
                }
                w.Indent--;

                w.WriteLine("{");
                w.Indent++;

                w.Write($"return new {ext.return_class_name.full_class_name}(stmt.QueryBuilder");
                foreach (var prop in ext.return_class_name.properties)
                {
                    w.Write($", {prop.para}");
                }
                if (ext.generic_types != null)
                {
                    foreach (var gentyp in ext.generic_types)
                    {
                        if (ext.return_class_name.generics != null && ext.return_class_name.generics.Contains(gentyp)) continue;

                        //w.Write($", new {gentyp}()");
                    }
                }
                w.WriteLine(");");

                w.Indent--;
                w.WriteLine("}");
            }

            w.Indent--;
            w.WriteLine("}");

            w.Indent--;
            w.WriteLine("}");

            w.Flush();
            return sw.ToString();
        }
    }
}
