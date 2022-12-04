using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class MinFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public MinFunction() { }
        public MinFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
