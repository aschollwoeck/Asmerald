using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class LesserConditionalExpression : SingularConditionalExpression
    {
        public LesserConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
