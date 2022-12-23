using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class InsertSelectStatement : SelectColumnsStatement
    {
        public InsertSelectStatement() { }
        public InsertSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
