using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OnMultiStatement<T, J> : IStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public (ISelectColumn<T> left, ISelectColumn<J> right) On { get; private set; }
        public OnMultiStatement(IQueryBuilder queryBuilder, (ISelectColumn<T> left, ISelectColumn<J> right) on)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.On = on;
        }
    }
}
