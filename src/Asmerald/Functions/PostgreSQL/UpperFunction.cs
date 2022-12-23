using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
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
