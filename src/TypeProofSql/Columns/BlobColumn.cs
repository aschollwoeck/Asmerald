using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;

namespace TypeProofSql.Columns
{

    public abstract class BlobColumn : IOrderByColumn, IOrderBy
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

    public abstract class BlobColumn<D> : StringColumn, IColumn<byte[], D> where D : ITable
    {
        public EqualConditionalExpression Equal(byte[] condition)
        {
            return new EqualConditionalExpression((IColumn)this, condition);
        }

        public GreaterConditionalExpression Greater(byte[] condition)
        {
            return new GreaterConditionalExpression((IColumn)this, condition);
        }

        public GreaterOrEqualConditionalExpression GreaterOrEqual(byte[] condition)
        {
            return new GreaterOrEqualConditionalExpression((IColumn)this, condition);
        }

        public InConditionalExpression In(IEnumerable<byte[]> condition)
        {
            return new InConditionalExpression((IColumn)this, condition);
        }

        public LesserConditionalExpression Lesser(byte[] condition)
        {
            return new LesserConditionalExpression((IColumn)this, condition);
        }

        public LesserOrEqualConditionalExpression LesserOrEqual(byte[] condition)
        {
            return new LesserOrEqualConditionalExpression((IColumn)this, condition);
        }

        public LikeConditionalExpression Like(byte[] condition)
        {
            return new LikeConditionalExpression((IColumn)this, condition);
        }

        public IsNullConditionalExpression IsNull()
        {
            return new IsNullConditionalExpression((IColumn)this);
        }

        public abstract ISelectColumnAlias<D> As(string name);

        public abstract ISelectColumn<D> Count();

        public ValueExpression Value(byte[] value) => new ValueExpression(this, value);
    }
}
