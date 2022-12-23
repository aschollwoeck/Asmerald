using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpsertWhereGroupMultiStatement : WhereGroupMultiStatement
    {
        public UpsertWhereGroupMultiStatement() { }
        public UpsertWhereGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
            : base(queryBuilder, conditionalGroupStatements)
        {
        }
    }
}
