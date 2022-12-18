using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpdateSetStatement : SetStatement
    {
        public ITable Table { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public UpdateSetStatement() { }
        public UpdateSetStatement(IQueryBuilder queryBuilder, ITable table, IEnumerable<ValueExpression> valueExpressions)
            : base(queryBuilder, valueExpressions)
        {
            this.Table = table;
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
