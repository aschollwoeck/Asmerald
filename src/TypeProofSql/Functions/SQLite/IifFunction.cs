using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Expressions.Functions.SQLite
{
    public class IifFunction
    {
        public IExpression X { get; private set; }
        public IExpression Y { get; private set; }
        public IExpression Z { get; private set; }

        public IifFunction(IExpression x, IExpression y, IExpression z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
