using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WithAsSelectStatement<T> : WithAsSelectStatement
        where T : ITable, new()
    {
        public WithAsSelectStatement() { }
        public WithAsSelectStatement(IQueryBuilder queryBuilder, IQueryBuilder subQuery)
            : base(queryBuilder, new T(), subQuery)
        {
        }
    }
}
