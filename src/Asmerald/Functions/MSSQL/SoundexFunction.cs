using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class SoundexFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public SoundexFunction() { }
        public SoundexFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
