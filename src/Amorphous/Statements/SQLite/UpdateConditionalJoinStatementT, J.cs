using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
