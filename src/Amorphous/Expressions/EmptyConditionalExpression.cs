using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class EmptyConditionalExpression : ConditionalExpression
    {
        public EmptyConditionalExpression(ISelectExpression column) : base(column, "")
        {

        }
    }
}
