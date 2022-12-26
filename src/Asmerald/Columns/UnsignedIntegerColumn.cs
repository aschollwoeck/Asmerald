using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;

namespace Asmerald.Columns
{
    public abstract class UnsignedIntegerColumn : IOrderByColumn, IOrderBy
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

    public abstract class UnsignedIntegerColumn<D> : UnsignedIntegerColumn, IColumn<uint, D> where D : ITable
    {
        public EqualConditionalExpression Equal(uint condition)
        {
            return new EqualConditionalExpression((IColumn)this, condition);
        }

        public GreaterConditionalExpression Greater(uint condition)
        {
            return new GreaterConditionalExpression((IColumn)this, condition);
        }

        public GreaterOrEqualConditionalExpression GreaterOrEqual(uint condition)
        {
            return new GreaterOrEqualConditionalExpression((IColumn)this, condition);
        }

        public InConditionalExpression In(IEnumerable<uint> condition)
        {
            return new InConditionalExpression((IColumn)this, condition);
        }

        public LesserConditionalExpression Lesser(uint condition)
        {
            return new LesserConditionalExpression((IColumn)this, condition);
        }

        public LesserOrEqualConditionalExpression LesserOrEqual(uint condition)
        {
            return new LesserOrEqualConditionalExpression((IColumn)this, condition);
        }

        public IsNullConditionalExpression IsNull()
        {
            return new IsNullConditionalExpression(this);
        }

        public abstract ISelectColumnAlias<D> As(string name);

        public abstract ISelectColumn<D> Count();

        public ValueExpression Value(uint value) => new ValueExpression(this, value);

        public BetweenConditionalExpression Between(uint minValue, uint maxValue)
        {
            return new BetweenConditionalExpression((IColumn)this, minValue, maxValue);
        }
    }
}
