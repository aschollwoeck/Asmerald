using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.QueryBuilders
{
    public class PreparedStatement : IPreparedStatement
    {
        public string Statement { get; private set; }
        public Dictionary<string, object> Parameters { get; private set; }

        public PreparedStatement(string statement, Dictionary<string, object> parameters)
        {
            this.Statement = statement;
            this.Parameters = parameters;
        }
    }
}
