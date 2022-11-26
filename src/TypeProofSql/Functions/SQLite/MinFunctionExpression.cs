using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class MinFunctionExpression : ISelectExpression
    {
        public List<IExpression> X { get; private set; } = new List<IExpression>();
        public MinFunctionExpression() { }
        public MinFunctionExpression(IEnumerable<IExpression> x
        )
        {
            this.X.AddRange(x);
        }
    }
}
