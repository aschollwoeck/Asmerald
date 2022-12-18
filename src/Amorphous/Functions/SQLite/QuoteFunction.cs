using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class QuoteFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public QuoteFunction() { }
        public QuoteFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
