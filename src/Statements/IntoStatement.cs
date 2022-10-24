using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class IntoStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }

        public IntoStatement(IQueryBuilder queryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.Table = table;
            this.QueryBuilder.AddStatment(this);
        }
    }

    public class IntoStatement<T> : IntoStatement where T : ITable
    {
        public IntoStatement(IQueryBuilder queryBuilder, T table)
            : base(queryBuilder, table)
        {
        }
    }
}
