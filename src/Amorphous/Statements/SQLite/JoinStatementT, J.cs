using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
