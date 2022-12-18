using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;
using System.Linq;

namespace Amorphous.Statements.SQLite
{
    public class OnMultiStatement<T, J> : OnMultiStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public OnMultiStatement() { }
        public OnMultiStatement(IQueryBuilder queryBuilder, IEnumerable<(ISelectColumn<T> left, ISelectColumn<J> right)> on)
            : base(queryBuilder, new T(), new J(), on.Select(s => ((ISelectColumn)s.left, (ISelectColumn)s.right)))
        {
        }
    }
}
