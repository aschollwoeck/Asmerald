using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
