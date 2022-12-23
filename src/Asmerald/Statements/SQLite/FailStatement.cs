using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.SQLite
{
    public class FailStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public FailStatement() { }
        public FailStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
