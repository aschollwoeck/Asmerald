using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MySQL
{
    public class MaxAggregateFunction : IFunction
    {
        public List<ISelectExpression> X { get; private set; } = new List<ISelectExpression>();
        public MaxAggregateFunction() { }
        public MaxAggregateFunction(IEnumerable<ISelectExpression> x)
        {
            this.X.AddRange(x);
        }
    }
}
