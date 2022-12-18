using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amorphous.SourceGenerator.Generators
{
    internal class StatementTestGenerator
    {
        internal string Generate(string testClass, IEnumerable<GenerateCodeClass> classObjs)
        {
            var sw = new StringWriter();
            IndentedTextWriter w = new IndentedTextWriter(sw);

            w.WriteLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
            w.WriteLine("using Dapper;");
            w.WriteLine("using System.Linq;");
            w.WriteLine("using System.Diagnostics;");
            w.WriteLine($"using TypeProofSql.{classObjs.First().nspace};");
            w.WriteLine("using System;");
            w.WriteLine($"using TypeProofSql.Statements.{classObjs.First().nspace};");
            w.WriteLine($"namespace TypeProofSql.Test.{classObjs.First().nspace}");
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
                    w.WriteLine($"var qb = new {classObj.nspace}DSLContext().QueryBuilder;");
                    w.WriteLine($"qb.AddStatment(new {classObj.class_name}());");
                    w.WriteLine("AssertEx.DoesNotThrow<NotImplementedException>(() => qb.Build());");
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
