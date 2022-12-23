using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class SignFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public SignFunction() { }
        public SignFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
