using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class IgnoreStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IgnoreStatement() { }
        public IgnoreStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
