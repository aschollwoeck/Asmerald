using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;

namespace Amorphous.Expressions
{
    public class IsNullConditionalExpression : EmptyConditionalExpression
    {
        public IsNullConditionalExpression(ISelectExpression column) : base(column)
        {

        }
    }
}
