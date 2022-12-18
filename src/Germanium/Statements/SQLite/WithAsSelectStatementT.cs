using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
