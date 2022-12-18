using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
