using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
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
