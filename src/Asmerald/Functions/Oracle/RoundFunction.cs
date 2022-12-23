using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.Oracle
{
    public class RoundFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public RoundFunction() { }
        public RoundFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
