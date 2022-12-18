using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
