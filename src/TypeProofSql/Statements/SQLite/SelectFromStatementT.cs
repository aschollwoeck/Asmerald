using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class SelectFromStatement<T> : FromStatement<T>
        where T : ITable, new()
    {
        public SelectFromStatement() { }
        public SelectFromStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
