using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class SubstrLengthFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public ISelectExpression Z { get; private set; }
        public SubstrLengthFunction() { }
        public SubstrLengthFunction(ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
