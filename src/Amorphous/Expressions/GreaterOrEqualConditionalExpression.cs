using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class GreaterOrEqualConditionalExpression : SingularConditionalExpression
    {
        public GreaterOrEqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
