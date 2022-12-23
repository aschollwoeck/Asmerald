using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class WithAsSelectStatement<T> : WithAsSelectStatement
        where T : ITable, new()
    {
        public WithAsSelectStatement() { }
        public WithAsSelectStatement(IQueryBuilder queryBuilder, IQueryBuilder subQuery)
            : base(queryBuilder, new T(), subQuery)
        {
        }
    }
}
