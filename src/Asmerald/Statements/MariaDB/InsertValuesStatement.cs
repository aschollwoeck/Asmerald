using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class InsertValuesStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();
        public InsertValuesStatement() { }
        public InsertValuesStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ValueExpressions.AddRange(valueExpressions);
        }
    }
}
