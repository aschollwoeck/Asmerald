using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class CrossJoinStatement<T, J> : CrossJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public CrossJoinStatement() { }
        public CrossJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
