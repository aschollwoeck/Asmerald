using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class InConditionalExpression : MultiValueConditionalExpression
    {
        public InConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
