using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
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
