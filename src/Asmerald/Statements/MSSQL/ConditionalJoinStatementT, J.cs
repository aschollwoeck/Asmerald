using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
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
