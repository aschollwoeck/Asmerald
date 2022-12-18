using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class SelectHavingStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ConditionalExpression ConditionalExpression { get; private set; }
        public SelectHavingStatement() { }
        public SelectHavingStatement(IQueryBuilder queryBuilder, ConditionalExpression conditionalExpression)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalExpression = conditionalExpression;
        }
    }
}
