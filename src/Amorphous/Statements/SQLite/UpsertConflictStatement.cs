using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
