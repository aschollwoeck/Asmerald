using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class AsSelectStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQuery { get; private set; }

        public AsSelectStatement(IQueryBuilder queryBuilder, IQueryBuilder subQuery)
        {
            this.QueryBuilder = queryBuilder;
            this.SubQuery = subQuery;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
