using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class IgnoreStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public IgnoreStatement() { }
        public IgnoreStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
