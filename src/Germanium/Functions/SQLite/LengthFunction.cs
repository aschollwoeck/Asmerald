using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class LengthFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LengthFunction() { }
        public LengthFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
