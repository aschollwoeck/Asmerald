using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class UpsertConflictSelectColumnsStatement : SelectColumnsStatement
    {
        public UpsertConflictSelectColumnsStatement() { }
        public UpsertConflictSelectColumnsStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
