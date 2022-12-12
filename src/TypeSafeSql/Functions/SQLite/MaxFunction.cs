using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class MaxFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public MaxFunction() { }
        public MaxFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
