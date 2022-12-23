using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class SelectFromSubQueryStatement<T> : FromSubQueryStatement<T>
        where T : ITable, new()
    {
        public SelectFromSubQueryStatement() { }
        public SelectFromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder)
        {
        }
    }
}
