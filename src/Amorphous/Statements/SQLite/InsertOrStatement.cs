using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
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
