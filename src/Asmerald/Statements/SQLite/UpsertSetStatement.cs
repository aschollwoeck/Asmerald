using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
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
