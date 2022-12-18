using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements
{
    public class OrStatement : ConditionalStatement
    {
        public OrStatement(ConditionalExpression conditionalExpression)
            : base(conditionalExpression)
        {
        }
    }
}
