using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Expressions;

namespace Germanium.Columns
{

    public interface IColumn : ISelectExpression
    {
        string Name();
    }

    public interface IColumn<T, Tbl> : IColumn where Tbl : ITable
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

        ISelectColumnAlias<Tbl> As(string name);
        ISelectColumn<Tbl> Count();
    }
}
