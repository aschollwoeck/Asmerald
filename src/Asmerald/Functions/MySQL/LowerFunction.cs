using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class LowerFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LowerFunction() { }
        public LowerFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
