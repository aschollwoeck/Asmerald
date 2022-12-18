using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
