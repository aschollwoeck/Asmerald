using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class UpsertConflictWhereStatement : WhereStatement
    {
        public UpsertConflictWhereStatement() { }
        public UpsertConflictWhereStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
            : base(queryBuilder, conditionalExpression)
        {
        }
    }
}
