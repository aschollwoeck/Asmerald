using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class InnerJoinStatement : ConditionalJoinStatement
    {
        public InnerJoinStatement() { }
        public InnerJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
        }
    }
}
