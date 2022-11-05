using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OnMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public (ISelectColumn left, ISelectColumn right) On { get; private set; }
        public OnMultiStatement(IQueryBuilder queryBuilder, (ISelectColumn left, ISelectColumn right) on)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.On = on;
        }
    }
}
