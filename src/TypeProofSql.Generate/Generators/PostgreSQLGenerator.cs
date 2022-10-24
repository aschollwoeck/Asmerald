using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeProofSql.Generate.Generators
{
    internal class PostgreSQLGenerator : IGenerator
    {
        public Task<Dictionary<string, string>> Generate()
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, string>> Generate(string nspace)
        {
            throw new NotImplementedException();
        }
    }
}
