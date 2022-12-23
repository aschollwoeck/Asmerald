using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class DefaultStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public DefaultStatement() { }
        public DefaultStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
