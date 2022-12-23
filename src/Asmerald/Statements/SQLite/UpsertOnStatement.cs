using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class UpsertOnStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertOnStatement() { }
        public UpsertOnStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
