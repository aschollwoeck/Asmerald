using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class GreaterConditionalExpression : SingularConditionalExpression
    {
        public GreaterConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
