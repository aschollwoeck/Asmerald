using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
