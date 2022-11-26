using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class IifFunctionExpression : ISelectExpression
    {
        public ConditionalExpression X { get; private set; }
        public IExpression Y { get; private set; }
        public IExpression Z { get; private set; }
        public IifFunctionExpression() { }
        public IifFunctionExpression(ConditionalExpression x, IExpression y, IExpression z
        )
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
