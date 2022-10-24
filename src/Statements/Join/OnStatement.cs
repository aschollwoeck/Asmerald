using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public class OnStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ISelectColumn Left { get; private set; }
        public ISelectColumn Right { get; private set; }

        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn left, ISelectColumn right)
        {
            this.QueryBuilder = queryBuilder;
            this.Left = left;
            this.Right = right;
        }

        public string Build()
        {
            return this.QueryBuilder.Build();
        }
    }

    public class OnStatement<T1, T2> : OnStatement where T1 : ITable where T2 : ITable
    {
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn<T1> left, ISelectColumn<T2> right)
            : base(queryBuilder, left, right)
        {

        }
    }
}
