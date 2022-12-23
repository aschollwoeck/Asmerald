using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.SQLite
{
    public class RoundDigitsFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public RoundDigitsFunction() { }
        public RoundDigitsFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
