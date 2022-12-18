using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class ConditionalExpression
    {
        public readonly ISelectExpression Column;
        public readonly object Value;

        public ConditionalExpression(ISelectExpression column, object value)
        {
            this.Column = column;
            this.Value = value;
        }
    }
}
