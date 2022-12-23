using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.Oracle
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
