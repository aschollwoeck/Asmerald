using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.SQLite
{
    public class StrftimeFunction : IFunction
    {
        public string Format { get; private set; }
        public ISelectExpression Value { get; private set; }
        public List<String> Modifier { get; private set; } = new List<String>();
        public StrftimeFunction() { }
        public StrftimeFunction(string format, ISelectExpression value, IEnumerable<String> modifier)
        {
            this.Format = format;
            this.Value = value;
            this.Modifier.AddRange(modifier);
        }
    }
}
