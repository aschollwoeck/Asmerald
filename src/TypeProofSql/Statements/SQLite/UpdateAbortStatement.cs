using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateAbortStatement : AbortStatement
    {
        public ITable Table { get; private set; }
        public UpdateAbortStatement() { }
        public UpdateAbortStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
