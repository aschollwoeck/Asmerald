using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class BetweenConditionalExpression : ConditionalExpression
    {
        public object MinValue { get; private set; }
        public object MaxValue { get; private set; }

        public BetweenConditionalExpression(ISelectExpression column, object minValue, object maxValue) : base(column, "")
        {
            this.MinValue = minValue;
            this.MinValue = maxValue;
        }
    }
}
