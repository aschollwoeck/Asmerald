using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
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
