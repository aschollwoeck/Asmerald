using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpsertDoStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertDoStatement() { }
        public UpsertDoStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
