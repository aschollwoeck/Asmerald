using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class RightOuterJoinStatement<T, J> : RightOuterJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public RightOuterJoinStatement() { }
        public RightOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
