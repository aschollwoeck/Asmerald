using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class LengthFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public LengthFunction() { }
        public LengthFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
