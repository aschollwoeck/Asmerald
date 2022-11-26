using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class TrimFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public TrimFunctionExpression() { }
        public TrimFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
