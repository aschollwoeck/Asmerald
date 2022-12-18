using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpsertOnStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertOnStatement() { }
        public UpsertOnStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
