using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class SingularConditionalExpression : ConditionalExpression
    {
        public SingularConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
