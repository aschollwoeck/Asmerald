using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;

namespace TypeProofSql.Columns
{

    public interface IColumn
    {
        string Name();
    }

    public interface IColumn<T, D> : IColumn where D : ITable
    {
        EqualConditionalExpression Equal(T condition);
        InConditionalExpression In(IEnumerable<T> condition);
        GreaterConditionalExpression Greater(T condition);
        GreaterOrEqualConditionalExpression GreaterOrEqual(T condition);
        LesserConditionalExpression Lesser(T condition);
        LesserOrEqualConditionalExpression LesserOrEqual(T condition);
        IsNullConditionalExpression IsNull();
        BetweenConditionalExpression Between(T minValue, T maxValue);

        ValueExpression Value(T value);

        ISelectColumnAlias<D> As(string name);
        ISelectColumn<D> Count();
    }
}
