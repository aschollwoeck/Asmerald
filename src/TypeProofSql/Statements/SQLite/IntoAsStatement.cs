using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class IntoAsStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public string Alias { get; private set; }
        public IntoAsStatement() { }
        public IntoAsStatement(IQueryBuilder queryBuilder, string alias)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Alias = alias;
        }
    }
}
