using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class RTrimFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public RTrimFunction() { }
        public RTrimFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
