using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class InsertAbortStatement : AbortStatement
    {
        public InsertAbortStatement() { }
        public InsertAbortStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
