using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
