using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InnerJoinStatement : ConditionalJoinStatement
    {
        public InnerJoinStatement() { }
        public InnerJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
        }
    }
}
