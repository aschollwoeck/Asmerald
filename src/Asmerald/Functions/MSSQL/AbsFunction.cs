using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class AbsFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public AbsFunction() { }
        public AbsFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
