using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class RoundFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public RoundFunctionExpression() { }
        public RoundFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
