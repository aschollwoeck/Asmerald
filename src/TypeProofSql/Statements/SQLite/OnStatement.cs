using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OnStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ISelectColumn Left { get; private set; }
        public ISelectColumn Right { get; private set; }
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn left, ISelectColumn right)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Left = left;
            this.Right = right;
        }
    }
}
