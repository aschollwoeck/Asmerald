using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class RoundFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public RoundFunction() { }
        public RoundFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
