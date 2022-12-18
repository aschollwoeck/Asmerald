using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class LowerFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LowerFunction() { }
        public LowerFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
