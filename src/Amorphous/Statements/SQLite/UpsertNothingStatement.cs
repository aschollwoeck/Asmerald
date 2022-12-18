using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
