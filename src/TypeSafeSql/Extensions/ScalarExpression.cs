using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Extensions
{
    public class ScalarExpression : ISelectExpression
    {
        public object Value { get; set; }
        public ScalarExpression(object value)
        {
            Value = value;
        }
    }
}
