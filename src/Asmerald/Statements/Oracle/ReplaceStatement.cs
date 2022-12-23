using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class ReplaceStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ReplaceStatement() { }
        public ReplaceStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
