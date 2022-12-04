using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class JoinStatement<T, J> : JoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public JoinStatement() { }
        public JoinStatement(IQueryBuilder queryBuilder, T left, J right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
