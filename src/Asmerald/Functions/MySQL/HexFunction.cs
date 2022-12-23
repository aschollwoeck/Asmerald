using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class HexFunction : IFunction
    {
        public ISelectExpression Z { get; private set; }
        public HexFunction() { }
        public HexFunction(ISelectExpression z)
        {
            this.Z = z;
        }
    }
}
