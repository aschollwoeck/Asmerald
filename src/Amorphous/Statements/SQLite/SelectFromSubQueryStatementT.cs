using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
