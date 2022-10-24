using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public class ValueStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ValueExpression> ValueExpressions { get; private set; } = new List<ValueExpression>();

        public ValueStatement(IQueryBuilder queryBuilder, IEnumerable<ValueExpression> valueExpressions)
        {
            this.QueryBuilder = queryBuilder;
            this.ValueExpressions.AddRange(valueExpressions);
            this.QueryBuilder.AddStatment(this);
        }
    }
}
