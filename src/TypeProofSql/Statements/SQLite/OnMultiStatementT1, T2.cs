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
    public class OnMultiStatement<T1, T2> : IStatement
        where T1 : ITable, new()
        where T2 : ITable, new()
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public (ISelectColumn<T1> left, ISelectColumn<T2> right) On { get; private set; }
        public OnMultiStatement(IQueryBuilder queryBuilder, (ISelectColumn<T1> left, ISelectColumn<T2> right) on)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.On = on;
        }
    }
}
