using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class JoinStatement<T1, T2> : IStatement
        where T1 : ITable, new()
        where T2 : ITable, new()
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public T1 Left { get; private set; }
        public T2 Right { get; private set; }
        public JoinStatement(IQueryBuilder queryBuilder, T1 left, T2 right)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Left = left;
            this.Right = right;
        }
    }
}
