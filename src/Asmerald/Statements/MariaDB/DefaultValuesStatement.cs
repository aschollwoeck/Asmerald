using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
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
