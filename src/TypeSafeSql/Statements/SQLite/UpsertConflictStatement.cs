using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
