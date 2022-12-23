using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
{
    public class UnlikelyFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UnlikelyFunction() { }
        public UnlikelyFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
