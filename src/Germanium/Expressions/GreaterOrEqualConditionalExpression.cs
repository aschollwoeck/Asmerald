using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class GreaterOrEqualConditionalExpression : SingularConditionalExpression
    {
        public GreaterOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
