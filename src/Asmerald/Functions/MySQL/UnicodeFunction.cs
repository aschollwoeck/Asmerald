using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class UnicodeFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UnicodeFunction() { }
        public UnicodeFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
