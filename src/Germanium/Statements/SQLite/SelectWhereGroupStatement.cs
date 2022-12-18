using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
