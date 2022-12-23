using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;

namespace Asmerald.Columns
{
    public abstract class DecimalColumn : IOrderByColumn, IOrderBy
    {
        public IOrderByColumn Asc()
        {
            return new OrderByAscColumn(Name());
        }

        public IOrderByColumn Desc()
        {
            return new OrderByDescColumn(Name());
        }

        public abstract string Name();
    }

    public abstract class DecimalColumn<D> : DecimalColumn, IColumn<decimal, D> where D : ITable
    {
        public EqualConditionalExpression Equal(decimal condition)
        {
            return new EqualConditionalExpression((IColumn)this, condition);
        }

        public GreaterConditionalExpression Greater(decimal condition)
        {
            return new GreaterConditionalExpression((IColumn)this, condition);
        }

        public GreaterOrEqualConditionalExpression GreaterOrEqual(decimal condition)
        {
            return new GreaterOrEqualConditionalExpression((IColumn)this, condition);
        }

        public InConditionalExpression In(IEnumerable<decimal> condition)
        {
            return new InConditionalExpression((IColumn)this, condition);
        }

        public LesserConditionalExpression Lesser(decimal condition)
        {
            return new LesserConditionalExpression((IColumn)this, condition);
        }

        public LesserOrEqualConditionalExpression LesserOrEqual(decimal condition)
        {
            return new LesserOrEqualConditionalExpression((IColumn)this, condition);
        }

        public IsNullConditionalExpression IsNull()
        {
            return new IsNullConditionalExpression(this);
        }

        public abstract ISelectColumnAlias<D> As(string name);

        public abstract ISelectColumn<D> Count();

        public ValueExpression Value(decimal value) => new ValueExpression(this, value);

        public BetweenConditionalExpression Between(decimal minValue, decimal maxValue)
        {
            return new BetweenConditionalExpression((IColumn)this, minValue, maxValue);
        }
    }
}
