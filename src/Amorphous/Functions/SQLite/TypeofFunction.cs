using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class TypeofFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public TypeofFunction() { }
        public TypeofFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
