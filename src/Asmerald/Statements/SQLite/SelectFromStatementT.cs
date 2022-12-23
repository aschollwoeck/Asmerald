using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class SelectFromStatement<T> : FromStatement<T>
        where T : ITable, new()
    {
        public SelectFromStatement() { }
        public SelectFromStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
