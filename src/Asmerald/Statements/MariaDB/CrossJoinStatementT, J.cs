using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
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
