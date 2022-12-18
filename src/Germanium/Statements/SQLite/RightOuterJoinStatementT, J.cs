using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
