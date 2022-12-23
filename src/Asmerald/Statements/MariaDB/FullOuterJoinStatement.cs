using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class FullOuterJoinStatement : ConditionalJoinStatement
    {
        public FullOuterJoinStatement() { }
        public FullOuterJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
        }
    }
}
