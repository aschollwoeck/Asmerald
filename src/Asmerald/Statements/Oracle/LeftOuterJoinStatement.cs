using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class LeftOuterJoinStatement : ConditionalJoinStatement
    {
        public LeftOuterJoinStatement() { }
        public LeftOuterJoinStatement(IQueryBuilder queryBuilder, ITable t, ITable j)
            : base(queryBuilder, t, j)
        {
        }
    }
}
