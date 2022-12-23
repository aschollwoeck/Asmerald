using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.Oracle
{
    public class UpperFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UpperFunction() { }
        public UpperFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
