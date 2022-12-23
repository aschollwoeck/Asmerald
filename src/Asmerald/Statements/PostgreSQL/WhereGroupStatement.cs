using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class WhereGroupStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ConditionalGroupStatement GroupExpr { get; private set; }
        public WhereGroupStatement() { }
        public WhereGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.GroupExpr = groupExpr;
        }
    }
}
