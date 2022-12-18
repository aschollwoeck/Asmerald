using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
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
