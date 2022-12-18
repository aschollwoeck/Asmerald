using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class ReturningAllStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ReturningAllStatement() { }
        public ReturningAllStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
