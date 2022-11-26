using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class MaxFunctionExpression : ISelectExpression
    {
        public List<ISelectExpression> X { get; private set; } = new List<ISelectExpression>();
        public MaxFunctionExpression() { }
        public MaxFunctionExpression(IEnumerable<ISelectExpression> x
        )
        {
            this.X.AddRange(x);
        }
    }
}
