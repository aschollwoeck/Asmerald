using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
{
    public class RTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public RTrimFunction() { }
        public RTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
