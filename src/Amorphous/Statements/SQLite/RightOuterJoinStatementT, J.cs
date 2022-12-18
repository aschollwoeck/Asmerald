using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
