using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateIgnoreStatement : IgnoreStatement
    {
        public ITable Table { get; private set; }
        public UpdateIgnoreStatement() { }
        public UpdateIgnoreStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
