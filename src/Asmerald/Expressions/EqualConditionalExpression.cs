using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class EqualConditionalExpression : SingularConditionalExpression
    {
        public EqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
