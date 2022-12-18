using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class UpsertNothingStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertNothingStatement() { }
        public UpsertNothingStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
