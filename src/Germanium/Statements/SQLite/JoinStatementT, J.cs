using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
