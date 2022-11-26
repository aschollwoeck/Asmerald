using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class StrftimeFunctionExpression : ISelectExpression
    {
        public string Format { get; private set; }
        public IExpression Value { get; private set; }
        public List<String> Modifier { get; private set; } = new List<String>();
        public StrftimeFunctionExpression() { }
        public StrftimeFunctionExpression(string format, IExpression value, IEnumerable<String> modifier
        )
        {
            this.Format = format;
            this.Value = value;
            this.Modifier.AddRange(modifier);
        }
    }
}
