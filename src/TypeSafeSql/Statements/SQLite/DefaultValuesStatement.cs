using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class DefaultValuesStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public DefaultValuesStatement() { }
        public DefaultValuesStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
