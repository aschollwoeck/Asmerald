using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class JoinAsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public string Alias { get; private set; }
        public JoinAsStatement() { }
        public JoinAsStatement(IQueryBuilder queryBuilder, string alias)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Alias = alias;
        }
    }
}
