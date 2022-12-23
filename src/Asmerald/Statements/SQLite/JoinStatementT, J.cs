using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class JoinStatement<T, J> : JoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public JoinStatement() { }
        public JoinStatement(IQueryBuilder queryBuilder, T left, J right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
