using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class ReplaceStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ReplaceStatement() { }
        public ReplaceStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
