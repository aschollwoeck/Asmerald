using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class CrossJoinStatement<T, J> : CrossJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public CrossJoinStatement() { }
        public CrossJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
