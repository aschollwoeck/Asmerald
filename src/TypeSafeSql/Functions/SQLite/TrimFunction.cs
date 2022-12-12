using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class TrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public TrimFunction() { }
        public TrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
