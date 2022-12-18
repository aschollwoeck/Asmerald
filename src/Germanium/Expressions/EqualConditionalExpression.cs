using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Columns;

namespace Germanium.Expressions
{
    public class EqualConditionalExpression : SingularConditionalExpression
    {
        public EqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
