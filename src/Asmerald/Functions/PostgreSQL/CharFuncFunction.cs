using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.PostgreSQL
{
    public class CharFuncFunction : IFunction
    {
        public ISelectExpression X1 { get; private set; }
        public ISelectExpression X2 { get; private set; }
        public List<ISelectExpression> Xn { get; private set; } = new List<ISelectExpression>();
        public CharFuncFunction() { }
        public CharFuncFunction(ISelectExpression x1, ISelectExpression x2, IEnumerable<ISelectExpression> xn)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Xn.AddRange(xn);
        }
    }
}
