using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements.Join
{
    public abstract class JoinStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public ITable Left { get; private set; }
        public ITable Right { get; private set; }

        public JoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
        {
            this.QueryBuilder = queryBuilder;
            this.Left = left;
            this.Right = right;
        }
    }

    public abstract class JoinStatement<T1, T2> : JoinStatement where T1 : ITable where T2 : ITable
    {
        public JoinStatement(IQueryBuilder queryBuilder, T1 left, T2 right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
