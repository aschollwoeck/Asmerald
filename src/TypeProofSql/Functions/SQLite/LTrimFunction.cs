using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class LTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LTrimFunction() { }
        public LTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
