using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class DeleteStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public DeleteStatement() { }
        public DeleteStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}
