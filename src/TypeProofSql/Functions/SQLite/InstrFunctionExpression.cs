using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class InstrFunctionExpression : ISelectExpression
    {
        public IExpression X { get; private set; }
        public IExpression Y { get; private set; }
        public InstrFunctionExpression() { }
        public InstrFunctionExpression(IExpression x, IExpression y
        )
        {
            this.X = x;
            this.Y = y;
        }
    }
}
