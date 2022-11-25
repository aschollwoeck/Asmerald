using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Expressions.Functions
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
