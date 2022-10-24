using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{

    public class FromStatement: IStatement, IQueryBuilderContainer
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }

        public FromStatement(IQueryBuilder queryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.Table = table;
            this.QueryBuilder.AddStatment(this);
        }
    }

    public class FromStatement<T> : FromStatement where T : ITable
    {
        public FromStatement(IQueryBuilder queryBuilder, T table)
            : base(queryBuilder, table)
        {
        }
    }
}
