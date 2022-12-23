using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class SelectHavingGroupStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ConditionalGroupStatement GroupExpr { get; private set; }
        public SelectHavingGroupStatement() { }
        public SelectHavingGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.GroupExpr = groupExpr;
        }
    }
}
