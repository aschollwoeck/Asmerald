using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
{
    public class DefaultValuesStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public DefaultValuesStatement() { }
        public DefaultValuesStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
