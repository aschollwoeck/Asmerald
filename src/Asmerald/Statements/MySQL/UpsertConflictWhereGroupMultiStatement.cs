using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpsertConflictWhereGroupMultiStatement : WhereGroupMultiStatement
    {
        public UpsertConflictWhereGroupMultiStatement() { }
        public UpsertConflictWhereGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
            : base(queryBuilder, conditionalGroupStatements)
        {
        }
    }
}
