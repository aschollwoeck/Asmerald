using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpsertConflictStatement : ConflictStatement
    {
        public UpsertConflictStatement() { }
        public UpsertConflictStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
