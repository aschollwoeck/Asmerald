using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class InConditionalExpression : MultiValueConditionalExpression
    {
        public InConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
