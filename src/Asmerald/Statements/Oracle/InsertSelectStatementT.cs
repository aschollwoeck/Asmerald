using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class InsertSelectStatement<T> : InsertSelectStatement
        where T : ITable, new()
    {
        public InsertSelectStatement() { }
        public InsertSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
