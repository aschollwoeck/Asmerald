using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
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
