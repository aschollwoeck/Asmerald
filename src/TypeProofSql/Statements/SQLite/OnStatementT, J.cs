using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OnStatement<T, J> : OnStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnStatement() { }
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn<T> left, ISelectColumn<J> right)
            : base(queryBuilder, new T(), new J(), left, right)
        {
        }
    }
}
