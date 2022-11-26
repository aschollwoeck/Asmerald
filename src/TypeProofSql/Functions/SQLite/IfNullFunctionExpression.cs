using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class IfNullFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public IfNullFunctionExpression() { }
        public IfNullFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }
    }
}
