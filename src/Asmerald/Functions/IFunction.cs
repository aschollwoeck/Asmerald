using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;

namespace Asmerald.Functions
{
    public interface IFunction : ISelectExpression
    {
    }

    public interface IFunction<T> : ISelectExpression
    {
        string Name();
        List<(string, object)> GetParameters();
    }
}
