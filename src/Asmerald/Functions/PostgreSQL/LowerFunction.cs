using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
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
