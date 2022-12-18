using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
