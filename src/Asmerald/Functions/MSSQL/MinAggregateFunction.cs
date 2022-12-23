using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class MinAggregateFunction : IFunction
    {
        public List<ISelectExpression> X { get; private set; } = new List<ISelectExpression>();
        public MinAggregateFunction() { }
        public MinAggregateFunction(IEnumerable<ISelectExpression> x)
        {
            this.X.AddRange(x);
        }
    }
}
