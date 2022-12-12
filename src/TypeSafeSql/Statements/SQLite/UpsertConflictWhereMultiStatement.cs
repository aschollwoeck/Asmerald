using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpsertConflictWhereMultiStatement : WhereMultiStatement
    {
        public UpsertConflictWhereMultiStatement() { }
        public UpsertConflictWhereMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
            : base(queryBuilder, conditionalStatements)
        {
        }
    }
}
