using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class SelectHavingGroupMultiStatement : WhereGroupMultiStatement
    {
        public SelectHavingGroupMultiStatement() { }
        public SelectHavingGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
            : base(queryBuilder, conditionalGroupStatements)
        {
        }
    }
}
