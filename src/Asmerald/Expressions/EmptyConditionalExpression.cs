using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class EmptyConditionalExpression : ConditionalExpression
    {
        public EmptyConditionalExpression(ISelectExpression column) : base(column, "")
        {

        }
    }
}
