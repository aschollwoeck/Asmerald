using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class SetStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public SetStatement() { }
        public SetStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
