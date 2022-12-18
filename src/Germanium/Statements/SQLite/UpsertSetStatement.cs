using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpsertSetStatement : SetStatement
    {
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public UpsertSetStatement() { }
        public UpsertSetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, valueExpressions)
        {
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
