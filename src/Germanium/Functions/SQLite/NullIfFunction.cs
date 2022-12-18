using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class NullIfFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public NullIfFunction() { }
        public NullIfFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
