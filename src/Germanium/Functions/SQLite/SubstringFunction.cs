using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class SubstringFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public SubstringFunction() { }
        public SubstringFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
