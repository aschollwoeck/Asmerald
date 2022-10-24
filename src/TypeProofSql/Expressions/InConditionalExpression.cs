using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class InConditionalExpression : MultiValueConditionalExpression
    {
        public InConditionalExpression(IColumn column, object value) : base(column, value)
        {

        }
    }
}
