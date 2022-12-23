using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class UpdateSetStatement<T> : UpdateSetStatement
        where T : ITable, new()
    {
        public UpdateSetStatement() { }
        public UpdateSetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, new T(), valueExpressions)
        {
        }
    }
}
