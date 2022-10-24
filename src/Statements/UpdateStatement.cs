using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class UpdateStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }

        public UpdateStatement(IQueryBuilder queryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.Table = table;
            this.QueryBuilder.AddStatment(this);
        }
    }

    public class UpdateStatement<T> : UpdateStatement where T : ITable
    {
        public UpdateStatement(IQueryBuilder queryBuilder, T table)
            : base(queryBuilder, table)
        {
        }
    }
}
