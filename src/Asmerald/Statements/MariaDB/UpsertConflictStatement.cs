using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
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
