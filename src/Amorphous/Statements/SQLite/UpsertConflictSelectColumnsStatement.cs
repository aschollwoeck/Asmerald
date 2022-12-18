using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
