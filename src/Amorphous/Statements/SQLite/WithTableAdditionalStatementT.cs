using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
