using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
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
