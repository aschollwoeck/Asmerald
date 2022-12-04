using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateRollbackStatement<T> : UpdateRollbackStatement
        where T : ITable, new()
    {
        public UpdateRollbackStatement() { }
        public UpdateRollbackStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
