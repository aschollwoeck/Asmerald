using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
