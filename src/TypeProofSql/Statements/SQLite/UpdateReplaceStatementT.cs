using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateReplaceStatement<T> : UpdateReplaceStatement
        where T : ITable, new()
    {
        public UpdateReplaceStatement() { }
        public UpdateReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
