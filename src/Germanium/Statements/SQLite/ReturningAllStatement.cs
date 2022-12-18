using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class ReturningAllStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ReturningAllStatement() { }
        public ReturningAllStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
