using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class InsertOrStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public InsertOrStatement() { }
        public InsertOrStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
