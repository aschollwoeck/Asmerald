using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;

namespace TypeProofSql.Expressions
{
    public class LikeConditionalExpression : SingularConditionalExpression
    {
        public LikeConditionalExpression(IColumn column, object value) : base(column, value)
        {

        }
    }
}
