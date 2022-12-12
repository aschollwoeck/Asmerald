using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class RollbackStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public RollbackStatement() { }
        public RollbackStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
