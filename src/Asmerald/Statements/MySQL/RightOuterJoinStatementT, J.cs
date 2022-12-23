using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class RightOuterJoinStatement<T, J> : RightOuterJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public RightOuterJoinStatement() { }
        public RightOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
