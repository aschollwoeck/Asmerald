using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class RTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public RTrimFunction() { }
        public RTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
