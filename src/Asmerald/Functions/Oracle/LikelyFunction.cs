using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.Oracle
{
    public class LikelyFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LikelyFunction() { }
        public LikelyFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
