using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class SelectWhereMultiStatement : WhereMultiStatement
    {
        public SelectWhereMultiStatement() { }
        public SelectWhereMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
            : base(queryBuilder, conditionalStatements)
        {
        }
    }
}
