using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.Oracle
{
    public class TrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public TrimFunction() { }
        public TrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
