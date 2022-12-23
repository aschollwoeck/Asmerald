using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class WithTableAdditionalStatement<T> : WithTableAdditionalStatement
        where T : ITable, new()
    {
        public WithTableAdditionalStatement() { }
        public WithTableAdditionalStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
