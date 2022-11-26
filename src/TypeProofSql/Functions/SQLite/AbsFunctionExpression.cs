using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class AbsFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public AbsFunctionExpression() { }
        public AbsFunctionExpression(IExpression x
        )
        {
            this.X = x;
        }

        public object ValueName() => this.X;
    }
}
