using System;
using System.Collections.Generic;
using TypeProofSql.Expressions;

namespace TypeProofSql.Functions.SQLite
{
    public class RandomblobFunction : IFunction
    {
        public int N { get; private set; }
        public RandomblobFunction() { }
        public RandomblobFunction(int n)
        {
            this.N = n;
        }
    }
}
