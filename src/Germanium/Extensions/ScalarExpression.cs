using System;
using System.Collections.Generic;
using System.Text;

namespace Germanium.Extensions
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
