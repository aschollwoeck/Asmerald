using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class IntoStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Table { get; private set; }
        public IntoStatement() { }
        public IntoStatement(IQueryBuilder queryBuilder, ITable table)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Table = table;
        }
    }
}
