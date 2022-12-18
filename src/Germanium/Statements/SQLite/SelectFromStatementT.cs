using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
