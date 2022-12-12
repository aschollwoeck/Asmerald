using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class DeleteWhereGroupStatement : WhereGroupStatement
    {
        public DeleteWhereGroupStatement() { }
        public DeleteWhereGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
            : base(queryBuilder, groupExpr)
        {
        }
    }
}
