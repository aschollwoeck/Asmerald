using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class UpdateFromSubQueryStatement<T> : FromSubQueryStatement
        where T : ITable, new()
    {
        public UpdateFromSubQueryStatement() { }
        public UpdateFromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder, new T())
        {
        }
    }
}
