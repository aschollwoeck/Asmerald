using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertSelectStatement<T> : InsertSelectStatement
        where T : ITable, new()
    {
        public InsertSelectStatement() { }
        public InsertSelectStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn<T>> columns)
            : base(queryBuilder, columns)
        {
        }
    }
}
