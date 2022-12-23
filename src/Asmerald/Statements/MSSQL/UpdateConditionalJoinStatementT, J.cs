using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class UpdateConditionalJoinStatement<T, J> : ConditionalJoinStatement<T, J>
        where T : ITable, new()
        where J : ITable, new()
    {
        public UpdateConditionalJoinStatement() { }
        public UpdateConditionalJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
