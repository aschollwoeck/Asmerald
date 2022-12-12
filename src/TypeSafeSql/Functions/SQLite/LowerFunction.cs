using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class LowerFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LowerFunction() { }
        public LowerFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
