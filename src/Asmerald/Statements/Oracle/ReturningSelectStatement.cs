using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class ReturningSelectStatement : SelectColumnsStatement
    {
        public ReturningSelectStatement() { }
        public ReturningSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
