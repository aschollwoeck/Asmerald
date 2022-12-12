using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;

namespace TypeProofSql.Columns
{

    public abstract class StringColumn : IOrderByColumn, IOrderBy
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

    public abstract class StringColumn<D> : StringColumn, IColumn<string, D> where D : ITable
    {
        public EqualConditionalExpression Equal(string condition)
        {
            return new EqualConditionalExpression((IColumn)this, condition);
        }

        public GreaterConditionalExpression Greater(string condition)
        {
            return new GreaterConditionalExpression((IColumn)this, condition);
        }

        public GreaterOrEqualConditionalExpression GreaterOrEqual(string condition)
        {
            return new GreaterOrEqualConditionalExpression((IColumn)this, condition);
        }

        public InConditionalExpression In(IEnumerable<string> condition)
        {
            return new InConditionalExpression((IColumn)this, condition);
        }

        public LesserConditionalExpression Lesser(string condition)
        {
            return new LesserConditionalExpression((IColumn)this, condition);
        }

        public LesserOrEqualConditionalExpression LesserOrEqual(string condition)
        {
            return new LesserOrEqualConditionalExpression((IColumn)this, condition);
        }

        public LikeConditionalExpression Like(string condition)
        {
            return new LikeConditionalExpression((IColumn)this, condition);
        }

        public IsNullConditionalExpression IsNull()
        {
            return new IsNullConditionalExpression((IColumn)this);
        }

        public abstract ISelectColumnAlias<D> As(string name);

        public abstract ISelectColumn<D> Count();

        public ValueExpression Value(string value) => new ValueExpression(this, value);

        public BetweenConditionalExpression Between(string minValue, string maxValue)
        {
            return new BetweenConditionalExpression((IColumn)this, minValue, maxValue);
        }
    }
}
