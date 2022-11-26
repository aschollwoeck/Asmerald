using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class FormatFunctionExpression : ISelectExpression
    {
        public string Format { get; private set; }
        public List<IExpression> Z { get; private set; } = new List<IExpression>();
        public FormatFunctionExpression() { }
        public FormatFunctionExpression(string format, IEnumerable<IExpression> z
        )
        {
            this.Format = format;
            this.Z.AddRange(z);
        }
    }
}
