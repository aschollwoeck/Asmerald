using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class LikeConditionalExpression : SingularConditionalExpression
    {
        public LikeConditionalExpression(ISelectExpression column, object value) : base(column, value)
        {

        }
    }
}
