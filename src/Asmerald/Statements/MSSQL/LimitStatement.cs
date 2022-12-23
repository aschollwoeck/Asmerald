using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
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
