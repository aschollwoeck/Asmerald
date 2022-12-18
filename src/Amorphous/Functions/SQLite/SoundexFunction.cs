using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
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
