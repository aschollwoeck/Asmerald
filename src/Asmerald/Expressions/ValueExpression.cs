﻿using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Columns;

namespace Asmerald.Expressions
{
    public class ValueExpression
    {
        public readonly ISelectExpression Column;
        public readonly object Value;

        public ValueExpression(ISelectExpression column, object value)
        {
            this.Column = column;
            this.Value = value;
        }
    }
}
