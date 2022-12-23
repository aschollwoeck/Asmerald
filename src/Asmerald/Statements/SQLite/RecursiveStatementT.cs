using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class RecursiveStatement<T> : RecursiveStatement
        where T : ITable, new()
    {
        public RecursiveStatement() { }
        public RecursiveStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectExpression> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
