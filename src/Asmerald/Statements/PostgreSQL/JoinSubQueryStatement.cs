using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.PostgreSQL
{
    public class JoinSubQueryStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IQueryBuilder SubQueryBuilder { get; private set; }
        public JoinSubQueryStatement() { }
        public JoinSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.SubQueryBuilder = subQueryBuilder;
        }
    }
}
