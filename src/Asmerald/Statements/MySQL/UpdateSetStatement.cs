using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
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
