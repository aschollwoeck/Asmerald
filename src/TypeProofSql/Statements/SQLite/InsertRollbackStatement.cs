using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertRollbackStatement : RollbackStatement
    {
        public InsertRollbackStatement() { }
        public InsertRollbackStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
