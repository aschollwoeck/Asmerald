using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class ZeroblobFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ZeroblobFunction() { }
        public ZeroblobFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
