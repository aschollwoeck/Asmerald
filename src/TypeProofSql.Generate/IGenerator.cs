using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.Generate
{
    public interface IGenerator
    {
        Task<Dictionary<string, string>> Generate();
        Task<Dictionary<string, string>> Generate(string nspace);
    }
}
