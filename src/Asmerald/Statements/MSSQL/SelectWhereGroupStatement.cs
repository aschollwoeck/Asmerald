using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class SelectWhereGroupStatement : WhereGroupStatement
    {
        public SelectWhereGroupStatement() { }
        public SelectWhereGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
            : base(queryBuilder, groupExpr)
        {
        }
    }
}
