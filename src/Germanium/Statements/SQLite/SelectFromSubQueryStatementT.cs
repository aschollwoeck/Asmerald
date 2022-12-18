using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
