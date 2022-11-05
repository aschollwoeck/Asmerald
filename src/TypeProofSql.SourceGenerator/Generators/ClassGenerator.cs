using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.SourceGenerator.Generators
{
    internal class ClassGenerator
    {
        internal string Generate(GenerateCodeStatement classObj)
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
            w.WriteLine($"namespace TypeProofSql.Statements.{classObj.nspace}");
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
                w.WriteLine("IStatement");
            }
            if (classObj.generics != null)
            {
                w.Indent++;
                foreach (var gen in classObj.generics)
                {
                    w.WriteLine($"where {gen} : ITable, new()");
                }
                w.Indent--;
            }

            w.WriteLine("{");
            w.Indent++;

            // Properties
            if (classObj.inherit_class == null)
            {
                w.WriteLine("public IQueryBuilder QueryBuilder { get; private set; }");
            }

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
            w.Write($"public {classObj.class_name}(IQueryBuilder queryBuilder");

            foreach (var prop in classObj.properties)
            {
                w.Write(", ");
                if(prop.is_list)
                {
                    w.Write($"IEnumerable<{prop.class_name}>");
                }
                else
                {
                    w.Write(prop.class_name);
                }
                w.Write($" {prop.para}");
            }
            w.WriteLine(")");

            if(classObj.inherit_class != null)
            {
                w.Indent++;
                w.Write($": base(queryBuilder");
                foreach (var para in classObj.inherit_class.parameters)
                {
                    w.Write($", {para}");
                }
                w.WriteLine(")");
                w.Indent--;
            }

            w.WriteLine("{");
            w.Indent++;

            // Constructor Body
            if(classObj.inherit_class == null)
            {
                w.WriteLine("this.QueryBuilder = queryBuilder;");
                w.WriteLine("this.QueryBuilder.AddStatment(this);");
            }

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

            w.Indent--;
            w.WriteLine("}");

            w.Indent--;
            w.WriteLine("}");


            w.Flush();
            return sw.ToString();
        }
    }
}
