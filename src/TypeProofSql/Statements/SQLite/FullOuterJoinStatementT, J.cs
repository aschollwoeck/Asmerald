using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class FullOuterJoinStatement<T, J> : FullOuterJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public FullOuterJoinStatement() { }
        public FullOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
