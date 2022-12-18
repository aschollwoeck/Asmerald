using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
