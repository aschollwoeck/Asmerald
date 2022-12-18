using System.Collections.Generic;
using Germanium.Columns;
using Germanium.QueryBuilders;
using Germanium.Expressions;

namespace Germanium.Statements.SQLite
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
