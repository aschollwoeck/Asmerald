using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class ConditionalJoinStatement<T, J> : JoinStatement<T, J>
        where T : ITable, new()
        where J : ITable, new()
    {
        public ConditionalJoinStatement() { }
        public ConditionalJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
