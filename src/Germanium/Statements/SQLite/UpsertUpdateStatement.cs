using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpsertUpdateStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertUpdateStatement() { }
        public UpsertUpdateStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
