using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class EqualConditionalExpression : SingularConditionalExpression
    {
        public EqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
