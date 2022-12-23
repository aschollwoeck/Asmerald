using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class MaxFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public MaxFunction() { }
        public MaxFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
