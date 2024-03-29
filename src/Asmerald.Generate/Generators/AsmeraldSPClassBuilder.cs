﻿using Asmerald.Columns;
using MySqlX.XDevAPI.Relational;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators
{
    public class AsmeraldSPClassBuilder
    {

        private class TestSP : StoredProcedures.IStoredProcedure
        {
            private readonly int Para1;
            private readonly string Para2;

            public TestSP(int para1, string para2)
            {
                Para1 = para1;
                Para2 = para2;
            }

            public string Name() => "Test";

            public List<(string, object)> GetParameters()
            {
                return new List<(string, object)>()
                {
                    ("Para1", Para1),
                    ("Para2", Para2)
                };
            }
        }

        public string Build(string nspace, StoredProcedureGenerate sp)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("/*");
            w.WriteLine($"This file was automatically generated by {nameof(Asmerald)}.{nameof(Asmerald.Generate)} library / executable.");
            w.WriteLine("It is not recommened to make manual changes in this file as any changes to this file will be overwritten when the next generation happens.");
            w.WriteLine("In case you need modifications please refer to adjusting the generation process itself.");
            w.WriteLine($"This is possible by creating your own executable project and referencing or forking {nameof(Asmerald)}.{nameof(Asmerald.Generate)} library / executable.");
            w.WriteLine("*/");
            w.WriteLine();

            w.WriteLine($"using {nameof(System)};");
            w.WriteLine($"using {nameof(Asmerald)};");
            w.WriteLine($"using {nameof(Asmerald)}.{nameof(Asmerald.Columns)};");
            w.WriteLine();

            if (String.IsNullOrEmpty(nspace) == false)
            {
                w.WriteLine($"namespace {nspace}.{sp.Database}");
                w.WriteLine("{");
                w.Indent++;
            }
            else
            {
                w.WriteLine($"namespace {sp.Database}");
                w.WriteLine("{");
                w.Indent++;
            }

            var ctorParas = sp.Parameters.Select(p => $"{p.Type} {p.Name_class.FirstCharToLower()}");

            if (String.IsNullOrEmpty(sp.Schema) == false)
            {
                w.WriteLine($"public partial class {sp.Schema}");
                w.WriteLine("{");
                w.Indent++;

                // Method to create an object of stored procedure
                w.WriteLine($"public static {sp.Name_class} {sp.Name}({String.Join(", ", ctorParas)}) => new {sp.Name_class}({String.Join(", ", sp.Parameters.Select(p => p.Name_class.FirstCharToLower()))});");
            }

            w.WriteLine($"public class {sp.Name_class} : {nameof(Asmerald)}.{nameof(Asmerald.StoredProcedures)}.{nameof(Asmerald.StoredProcedures.IStoredProcedure)}");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine($"public string {nameof(Asmerald.StoredProcedures.IStoredProcedure.Name)}() => \"{sp.Schema}.{sp.Name}\";");
            w.WriteLine();

            foreach (var para in sp.Parameters)
            {
                w.WriteLine($"private readonly {para.Type} {para.Name_class};");
            }

            w.WriteLine();
            w.WriteLine($"public {sp.Name_class}({String.Join(", ", ctorParas)})");
            w.WriteLine("{");
            w.Indent++;

            foreach (var p in sp.Parameters)
            {
                w.WriteLine($"this.{p.Name_class} = {p.Name_class.FirstCharToLower()};");
            }

            w.Indent--;
            w.WriteLine("}");

            w.WriteLine();
            w.WriteLine("public System.Collections.Generic.List<(string, object)> GetParameters()");
            w.WriteLine("{");
            w.Indent++;

            w.WriteLine("return new System.Collections.Generic.List<(string, object)>()");
            w.WriteLine("{");
            w.Indent++;

            for (int i = 0; i < sp.Parameters.Count; i++)
            {
                w.Write($"(\"{sp.Parameters[i].Name}\", {sp.Parameters[i].Name_class})");
                if(i < sp.Parameters.Count - 1)
                {
                    w.Write(",");
                }
                w.WriteLine();
            }

            w.Indent--;
            w.WriteLine("};");

            w.Indent--;
            w.WriteLine("}");

            w.Indent--;
            w.WriteLine("}");

            if (String.IsNullOrEmpty(sp.Schema) == false)
            {
                w.Indent--;
                w.WriteLine("}");
            }

            w.Indent--;
            w.WriteLine("}");

            w.Flush();
            return sw.ToString();
        }
    }
}
