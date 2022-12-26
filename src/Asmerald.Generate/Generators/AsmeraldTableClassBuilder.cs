using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators
{
    public class AsmeraldTableClassBuilder
    {
        public string Build(string nspace, TableGenerate table)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using System;");
            w.WriteLine("using Germanium;");
            w.WriteLine("using Germanium.Columns;");
            w.WriteLine();

            if (String.IsNullOrEmpty(nspace) == false)
            {
                w.WriteLine($"namespace {nspace}");
                w.WriteLine("{");
                w.Indent++;
            }

            w.Write($"public class {table.Name_class} : ITable");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine($"string ITable.Name() => \"{table.Name}\";");

            foreach (var column in table.Columns)
            {
                w.WriteLine($"public static {column.Name_class} {column.Name_method}() => new {column.Name_class}();");
                w.WriteLine($"public static {column.Name_class} {column.Name_method}(string tableAlias) => new {column.Name_class}(tableAlias);");
            }

            foreach (var column in table.Columns)
            {
                w.WriteLine($"public class {column.Name_class} : {column.Type}<{table.Name_class}>, ISelectColumn<{table.Name_class}>, ISelectColumnAlias<{table.Name_class}>");
                w.WriteLine("{");
                w.Indent++;

                w.WriteLine($"private readonly string _name = \"{column.Name}\";");
                w.WriteLine($"string ISelectColumn.Name => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"readonly string? TableAlias;");
                w.WriteLine($"public {column.Name_class}() {{ }}");
                w.WriteLine($"public {column.Name_class}(string tableAlias) {{ this.TableAlias = tableAlias; }}");
                w.WriteLine($"public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $\"{{TableAlias}}.{{_name}}\";");
                w.WriteLine($"public override ISelectColumnAlias<{table.Name_class}> As(string name) => new AliasColumn<{table.Name_class}>(this, name);");
                w.WriteLine($"public override ISelectColumn<{table.Name_class}> Count() => new CountColumn<{table.Name_class}>(this);");

                w.Indent--;
                w.WriteLine("}");
            }

            w.Indent--;
            w.WriteLine("}");

            if (String.IsNullOrEmpty(nspace) == false)
            {
                w.Indent--;
                w.WriteLine("}");
            }

            w.Flush();
            return sw.ToString();
        }
    }
}
