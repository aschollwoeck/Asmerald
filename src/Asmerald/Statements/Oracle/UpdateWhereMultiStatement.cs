using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class UpdateWhereMultiStatement : WhereMultiStatement
    {
        public UpdateWhereMultiStatement() { }
        public UpdateWhereMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
            : base(queryBuilder, conditionalStatements)
        {
        }
    }
}
