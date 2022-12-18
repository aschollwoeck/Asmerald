using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
