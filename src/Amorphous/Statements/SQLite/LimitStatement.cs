using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
