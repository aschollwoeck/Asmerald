using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class UpdateRollbackStatement : RollbackStatement
    {
        public ITable Table { get; private set; }
        public UpdateRollbackStatement() { }
        public UpdateRollbackStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}
