using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.SourceGenerator
{
    internal class MermaidReader
    {
        public MermaidReader()
        {
            
        }

        public List<(string baseClass, string method, string extClass)> Parse(StreamReader streamReader)
        {
            List<(string baseClass, string method, string retClass)> methodChaining = new List<(string baseClass, string method, string retClass)>();

            HashSet<string> subgraphs = new HashSet<string>();

            // Read each line
            while (streamReader.EndOfStream == false)
            {
                var line = streamReader.ReadLine();

                if (line == null)
                {
                    continue;
                }
                else if (line.StartsWith("subgraph"))
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
                else
                {
                    // DeleteWhereGroup --> IDeleteEnd
                    // DeleteWhere -->|Returning| Returning

                    // Parse line to method chain information
                    var kv = line.Split("-->")
                            .Where(s => !String.IsNullOrEmpty(s.Trim()))
                            .ToList();

                    var baseClass = kv[0];
                    var method = "";
                    var retClass = "";

                    if (kv[1].Contains('|'))
                    {
                        var sp = kv[1]
                            .Split('|')
                            .Where(s => !String.IsNullOrEmpty(s.Trim()));

                        method = sp.First();
                        retClass = sp.Last();
                    }
                    else
                    {
                        retClass = kv.Last();
                    }

                    methodChaining.Add((baseClass, method, retClass));
                }
            }

            List<(string baseClass, string method, string retClass)> res = new List<(string baseClass, string method, string retClass)>();

            foreach (var methodChain in methodChaining)
            {
                //DeleteFrom --> IDeleteEnd
                //DeleteWhere --> IDeleteEnd
                //DeleteWhereGroup --> IDeleteEnd
                //ISelect -->|OrderBy| IOrderBy
                //ISelect -->|Limit| Limit

                // -> Subgraph on left = Start / Base class
                // -> Subgraph on right = End / Return class

                var bCls = subgraphs.Where(s => s == methodChain.baseClass + "End");
                var eCls = subgraphs.Where(s => s == methodChain.retClass + "End");
            }

            return res;
        }
    }
}
