using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class MinFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public MinFunction() { }
        public MinFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
