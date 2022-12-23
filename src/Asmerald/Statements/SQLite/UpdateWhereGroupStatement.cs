using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class UpdateWhereGroupStatement : WhereGroupStatement
    {
        public UpdateWhereGroupStatement() { }
        public UpdateWhereGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
            : base(queryBuilder, groupExpr)
        {
        }
    }
}
