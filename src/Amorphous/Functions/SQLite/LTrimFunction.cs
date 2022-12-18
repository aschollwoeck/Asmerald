using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class LTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LTrimFunction() { }
        public LTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
