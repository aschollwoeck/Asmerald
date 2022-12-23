using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.Expressions
{
    public interface IExpression
    {
        object ValueName();
    }

    public interface IExpression<T> : IExpression
    {
        new T ValueName();
    }
}
