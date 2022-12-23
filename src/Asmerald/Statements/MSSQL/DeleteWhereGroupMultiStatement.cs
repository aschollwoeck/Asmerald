using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class DeleteWhereGroupMultiStatement : WhereGroupMultiStatement
    {
        public DeleteWhereGroupMultiStatement() { }
        public DeleteWhereGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
            : base(queryBuilder, conditionalGroupStatements)
        {
        }
    }
}
