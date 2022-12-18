using System;
using System.Collections.Generic;
using Germanium.Expressions;

namespace Germanium.Functions.SQLite
{
    public class UnlikelyFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public UnlikelyFunction() { }
        public UnlikelyFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
