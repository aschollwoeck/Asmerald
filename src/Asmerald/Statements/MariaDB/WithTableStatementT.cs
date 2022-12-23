using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class WithTableStatement<T> : WithTableStatement
        where T : ITable, new()
    {
        public WithTableStatement() { }
        public WithTableStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
