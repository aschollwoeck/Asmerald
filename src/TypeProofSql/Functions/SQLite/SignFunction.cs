using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class SignFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public SignFunction() { }
        public SignFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
