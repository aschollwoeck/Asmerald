using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class SingularConditionalExpression : ConditionalExpression
    {
        public SingularConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
