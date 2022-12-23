using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class ZeroblobFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ZeroblobFunction() { }
        public ZeroblobFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
