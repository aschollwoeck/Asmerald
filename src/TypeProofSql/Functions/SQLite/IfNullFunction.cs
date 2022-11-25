using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Expressions.Functions.SQLite
{
    public class IfNullFunction
    {
        public IExpression X { get; private set; }
        public IExpression Y { get; private set; }

        public IfNullFunction(IExpression x, IExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
