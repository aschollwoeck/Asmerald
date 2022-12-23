using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
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
