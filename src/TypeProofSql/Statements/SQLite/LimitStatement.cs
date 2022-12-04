using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class LimitStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public int Limit { get; private set; }
        public LimitStatement() { }
        public LimitStatement(IQueryBuilder queryBuilder, int limit)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Limit = limit;
        }
    }
}
