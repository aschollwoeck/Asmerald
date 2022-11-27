using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class TrimYFunction : ISelectExpression
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public TrimYFunction() { }
        public TrimYFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}