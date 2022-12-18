using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
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
