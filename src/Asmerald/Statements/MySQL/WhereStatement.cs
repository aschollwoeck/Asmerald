using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class WhereStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ConditionalExpression ConditionalExpression { get; private set; }
        public WhereStatement() { }
        public WhereStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
