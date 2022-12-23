using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class IifFunction : IFunction
    {
        public ConditionalExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public ISelectExpression Z { get; private set; }
        public IifFunction() { }
        public IifFunction(ConditionalExpression x, ISelectExpression y, ISelectExpression z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
