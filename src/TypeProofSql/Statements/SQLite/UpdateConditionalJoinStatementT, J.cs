using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateConditionalJoinStatement<T, J> : ConditionalJoinStatement<T, J>
        where T : ITable, new()
        where J : ITable, new()
    {
        public UpdateConditionalJoinStatement() { }
        public UpdateConditionalJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
