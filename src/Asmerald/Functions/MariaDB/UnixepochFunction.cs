using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MariaDB
{
    public class UnixepochFunction : IFunction
    {
        public ISelectExpression Value { get; private set; }
        public List<String> Modifier { get; private set; } = new List<String>();
        public UnixepochFunction() { }
        public UnixepochFunction(ISelectExpression value, IEnumerable<String> modifier)
        {
            this.Value = value;
            this.Modifier.AddRange(modifier);
        }
    }
}
