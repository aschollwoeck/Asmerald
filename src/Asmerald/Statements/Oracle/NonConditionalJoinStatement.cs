using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class NonConditionalJoinStatement : JoinStatement
    {
        public NonConditionalJoinStatement() { }
        public NonConditionalJoinStatement(IQueryBuilder queryBuilder, ITable left, ITable right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
