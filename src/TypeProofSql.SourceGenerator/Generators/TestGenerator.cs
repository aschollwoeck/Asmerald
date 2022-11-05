using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.SourceGenerator.Generators
{
    internal class TestGenerator
    {
        internal string Generate(string testClass, IEnumerable<GenerateCodeStatement> classObjs)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            w.WriteLine("using Dapper;");
            w.WriteLine("using System.Linq;");
            w.WriteLine("using System.Diagnostics;");
            w.WriteLine("using TypeProofSql.SQLite;");
            w.WriteLine("using System;");
            w.WriteLine("using TypeProofSql.Statements.SQLite;");
            w.WriteLine("namespace TypeProofSql.Test");
            w.WriteLine("{");
            w.Indent++;
            w.WriteLine("[TestClass]");
            w.WriteLine($"public class {testClass}");
            w.WriteLine("{");
            w.Indent++;

            foreach (var classObj in classObjs)
            {
                // No generics - only base classes are tested
                if (classObj.generics == null || classObj.generics.Count == 0)
                {
                    w.WriteLine("[TestMethod]");
                    w.WriteLine($"public void {classObj.class_name}ImplementTest()");
                    w.WriteLine("{");
                    w.Indent++;
                    w.WriteLine("var qb = new SQLiteDSLContext().QueryBuilder;");
                    w.WriteLine($"qb.AddStatment(new {classObj.class_name}());");
                    w.WriteLine("qb.Build();");
                    w.Indent--;
                    w.WriteLine("}");
                }
            }

            w.Indent--;
            w.WriteLine("}");

            w.Indent--;
            w.WriteLine("}");

            return sw.ToString();
        }
    }
}
