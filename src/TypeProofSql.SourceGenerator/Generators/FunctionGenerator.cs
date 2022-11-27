using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.SourceGenerator.Generators
{
    internal class FunctionGenerator
    {
        internal string Generate(GenerateCodeClass classObj)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using System;");
            w.WriteLine("using System.Collections.Generic;");
            w.WriteLine("using System.Text;");
            w.WriteLine("using TypeProofSql.Columns;");
            w.WriteLine("using TypeProofSql.Statements;");
            w.WriteLine("using TypeProofSql.QueryBuilders;");
            w.WriteLine("using TypeProofSql.Expressions;");
            w.WriteLine();
            w.WriteLine($"namespace TypeProofSql.Functions.{classObj.nspace}");
            w.WriteLine("{");
            w.Indent++;
            
            // Class name and inheritance
            w.Write($"public class {classObj.full_class_name} : ");
            if (classObj.inherit_class != null)
            {
                w.WriteLine(classObj.inherit_class.full_class_name);
            }
            else
            {
                w.WriteLine("ISelectExpression");
            }

            w.WriteLine("{");
            w.Indent++;

            foreach (var prop in classObj.properties)
            {
                if(classObj.inherit_class?.base_class != null && classObj.inherit_class.base_class.properties.Select(p => p.prop).Contains(prop.prop))
                {
                    // When property already exists in inherited class, we don't add the property again
                    continue;
                }

                if (prop.is_list) {
                    w.WriteLine($"public List<{prop.class_name}> {prop.prop} {{ get; private set; }} = new List<{prop.class_name}>();");
                }
                else
                {
                    w.WriteLine($"public {prop.class_name} {prop.prop} {{ get; private set; }}");
                }
            }

            // Default constructor
            w.WriteLine($"public {classObj.class_name}() {{ }}");

            // Constructor
            if (classObj.properties != null && classObj.properties.Count > 0)
            {
                w.Write($"public {classObj.class_name}(");
                w.Write(
                    String.Join(", ",
                        classObj.properties
                        .Select(prop =>
                        {
                            if (prop.is_list)
                            {
                                return $"IEnumerable<{prop.class_name}> {prop.para}";
                            }
                            return $"{prop.class_name} {prop.para}";
                        })
                    )
                );
                w.WriteLine(")");

                if (classObj.inherit_class != null)
                {
                    w.Indent++;
                    w.Write($": base({String.Join(", ", classObj.inherit_class.parameters)})");
                    w.Indent--;
                }

                w.WriteLine("{");
                w.Indent++;

                foreach (var prop in classObj.properties)
                {
                    if (classObj.inherit_class?.base_class != null && classObj.inherit_class.base_class.properties.Select(p => p.prop).Contains(prop.prop))
                    {
                        // When property already exists in inherited class, we don't add the property again
                        continue;
                    }

                    if (prop.is_list)
                    {
                        w.WriteLine($"this.{prop.prop}.AddRange({prop.para});");
                    }
                    else
                    {
                        w.WriteLine($"this.{prop.prop} = {prop.para};");
                    }
                }

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
