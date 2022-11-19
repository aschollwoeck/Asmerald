using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;

namespace TypeProofSql.Columns
{
    public abstract class DateTimeColumn : IOrderByColumn, IOrderBy
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

    public abstract class DateTimeColumn<D> : DateTimeColumn, IColumn<DateTime, D> where D : ITable
    {
        public EqualConditionalExpression Equal(DateTime condition)
        {
            return new EqualConditionalExpression((IColumn)this, condition);
        }

        public GreaterConditionalExpression Greater(DateTime condition)
        {
            return new GreaterConditionalExpression((IColumn)this, condition);
        }

        public GreaterOrEqualConditionalExpression GreaterOrEqual(DateTime condition)
        {
            return new GreaterOrEqualConditionalExpression((IColumn)this, condition);
        }

        public InConditionalExpression In(IEnumerable<DateTime> condition)
        {
            return new InConditionalExpression((IColumn)this, condition);
        }

        public LesserConditionalExpression Lesser(DateTime condition)
        {
            return new LesserConditionalExpression((IColumn)this, condition);
        }

        public LesserOrEqualConditionalExpression LesserOrEqual(DateTime condition)
        {
            return new LesserOrEqualConditionalExpression((IColumn)this, condition);
        }

        public IsNullConditionalExpression IsNull()
        {
            return new IsNullConditionalExpression(this);
        }

        public abstract ISelectColumnAlias<D> As(string name);

        public abstract ISelectColumn<D> Count();

        public ValueExpression Value(DateTime value) => new ValueExpression(this, value);

        public BetweenConditionalExpression Between(DateTime minValue, DateTime maxValue)
        {
            return new BetweenConditionalExpression(this, minValue, maxValue);
        }
    }
}
