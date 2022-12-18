using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Amorphous.SourceGenerator
{
    internal class MermaidReader
    {
        public class Knot
        {
            public string Code { get; set; }
            public string Class { get; set; }

            public Knot(string code, string @class)
            {
                Code = code;
                Class = @class;
            }

            public Knot(Knot from)
            {
                Code = from.Code;
                Class = from.Class;
            }
        }

        private readonly string Root;

        public MermaidReader(string root)
        {
            this.Root = root;
        }

        public List<(string baseClass, string method, string retClass)> Parse(StreamReader streamReader)
        {
            List<(Knot baseClass, string method, Knot retClass)> methodChaining = new List<(Knot baseClass, string method, Knot retClass)>();

            HashSet<string> subgraphs = new HashSet<string>();

            // Read each line
            while (streamReader.EndOfStream == false)
            {
                var line = streamReader.ReadLine();

                if (line == null)
                {
                    continue;
                }

                line = line
                    .Replace("//", "")
                    .Replace("Root", Root)
                    .Trim();

                if (line.StartsWith("subgraph"))
                {
                    var sg = line
                        .Replace("subgraph", "")
                        .Trim();

                    subgraphs.Add(sg);
                }
                else if (line.StartsWith("end"))
                {
                    //subgraphs.Pop();
                }
                else if(line.Contains("-->"))
                {
                    // DeleteWhereGroup --> IDeleteEnd
                    // DeleteWhere -->|Returning| Returning

                    // Parse line to method chain information
                    var kv = line.Split("-->")
                            .Where(s => !String.IsNullOrEmpty(s.Trim()))
                            .ToList();

                    var baseClass = this.GetClassName(kv[0]);
                    string method = "";
                    Knot retClass = new Knot(baseClass);

                    if (kv[1].Contains('|'))
                    {
                        var sp = kv[1]
                            .Split('|')
                            .Where(s => !String.IsNullOrEmpty(s.Trim()));

                        method = sp.First();
                        retClass = this.GetClassName(sp.Last());
                    }
                    else
                    {
                        retClass = this.GetClassName(kv.Last());
                    }

                    methodChaining.Add((baseClass, method, retClass));
                }
            }

            List<(string baseClass, string method, string retClass)> res = new List<(string baseClass, string method, string retClass)>();

            foreach (var methodChain in methodChaining)
            {
                // -> Subgraph on left = Start / Base class
                // -> Subgraph on right = End / Return class

                //DeleteFrom --> IDeleteEnd
                //DeleteWhere --> IDeleteEnd
                //DeleteWhereGroup --> IDeleteEnd
                //ISelect -->|OrderBy| IOrderBy
                //ISelect -->|Limit| Limit

                if(methodChain.method == String.Empty)
                {
                    continue;
                }

                // left = Start / Base class
                var baseClasses = GetDerivedClasses(methodChain.baseClass, methodChaining);

                // -> Subgraph on right = End / Return class
                var retClasses = GetDerivedClasses(methodChain.retClass, methodChaining);

                // Now we multiple each base with return class with given method name
                // This way we take subgraphs into account
                foreach (var bCls in baseClasses)
                {
                    foreach (var rCls in retClasses)
                    {
                        res.Add((bCls.Class, methodChain.method, rCls.Class));
                    }
                }
            }

            return res;
        }

        private Knot GetClassName(string cls)
        {
            if(cls.Contains("["))
            {
                var p = cls
                    .Split('[', ']')
                    .Select(s => s.Trim())
                    .Where(s => String.IsNullOrEmpty(s) == false);

                return new Knot(p.First(), p.Last());
                 
            }

            return new Knot(cls.Trim(), cls.Trim());
        }

        private IEnumerable<Knot> GetDerivedClasses(Knot cls, List<(Knot baseClass, string method, Knot retClass)> methodChaining)
        {
            if (cls.Code.StartsWith("SG") == false) return new Knot[] { cls };

            List<string> res = new List<string>();

            return methodChaining
                .Where(mc => mc.method == String.Empty)
                .Where(mc => mc.retClass.Code == cls.Code)
                .Select(mc => mc.baseClass)
                .Select(rc => GetDerivedClasses(rc, methodChaining))
                .SelectMany(rc => rc);
        }
    }
}
