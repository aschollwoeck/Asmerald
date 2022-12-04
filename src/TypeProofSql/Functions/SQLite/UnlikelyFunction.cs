using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class UnlikelyFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UnlikelyFunction() { }
        public UnlikelyFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
