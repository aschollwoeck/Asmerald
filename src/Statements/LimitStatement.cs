using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class LimitStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public int Limit { get; private set; }

        public LimitStatement(IQueryBuilder queryBuilder, int limit)
        {
            this.QueryBuilder = queryBuilder;
            this.Limit = limit;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
