using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class ZerblobFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public ZerblobFunctionExpression() { }
        public ZerblobFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
