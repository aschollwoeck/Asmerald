using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class DateTimeFuncFunction : IFunction
    {
        public ISelectExpression Value { get; private set; }
        public List<String> Modifier { get; private set; } = new List<String>();
        public DateTimeFuncFunction() { }
        public DateTimeFuncFunction(ISelectExpression value, IEnumerable<String> modifier)
        {
            this.Value = value;
            this.Modifier.AddRange(modifier);
        }
    }
}
