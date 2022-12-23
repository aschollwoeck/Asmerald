using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class LikeFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public LikeFunction() { }
        public LikeFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
