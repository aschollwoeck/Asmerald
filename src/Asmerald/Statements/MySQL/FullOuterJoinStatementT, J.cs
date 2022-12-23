using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class FullOuterJoinStatement<T, J> : FullOuterJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public FullOuterJoinStatement() { }
        public FullOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
