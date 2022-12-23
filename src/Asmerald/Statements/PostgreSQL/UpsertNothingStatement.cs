using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class UpsertNothingStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertNothingStatement() { }
        public UpsertNothingStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
