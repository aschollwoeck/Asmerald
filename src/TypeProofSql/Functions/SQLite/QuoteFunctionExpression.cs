using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class QuoteFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public QuoteFunctionExpression() { }
        public QuoteFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
