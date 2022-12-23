using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
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
