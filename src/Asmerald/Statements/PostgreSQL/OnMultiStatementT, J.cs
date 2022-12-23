using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;
using System.Linq;

namespace Asmerald.Statements.PostgreSQL
{
    public class OnMultiStatement<T, J> : OnMultiStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnMultiStatement() { }
        public OnMultiStatement(IQueryBuilder queryBuilder, IEnumerable<(ISelectColumn<T> left, ISelectColumn<J> right)> on)
            : base(queryBuilder, new T(), new J(), on.Select(o => ((ISelectColumn)o.left, (ISelectColumn)o.right)))
        {
        }
    }
}
