using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class UnicodeFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UnicodeFunction() { }
        public UnicodeFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
