using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class AbsFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public AbsFunction() { }
        public AbsFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
