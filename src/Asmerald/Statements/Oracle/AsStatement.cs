using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class AsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public AsStatement() { }
        public AsStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
