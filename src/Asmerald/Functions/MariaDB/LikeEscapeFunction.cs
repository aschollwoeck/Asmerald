using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MariaDB
{
    public class LikeEscapeFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public ISelectExpression Z { get; private set; }
        public LikeEscapeFunction() { }
        public LikeEscapeFunction(ISelectExpression x, ISelectExpression y, ISelectExpression z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
