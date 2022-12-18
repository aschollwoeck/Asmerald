using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
