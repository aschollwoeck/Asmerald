using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
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
