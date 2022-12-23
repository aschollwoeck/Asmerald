using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class GlobFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public GlobFunction() { }
        public GlobFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
