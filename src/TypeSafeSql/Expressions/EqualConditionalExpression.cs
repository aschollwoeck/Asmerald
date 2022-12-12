using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class EqualConditionalExpression : SingularConditionalExpression
    {
        public EqualConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
