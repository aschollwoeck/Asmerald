using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
