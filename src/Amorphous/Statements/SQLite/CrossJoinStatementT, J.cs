using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
