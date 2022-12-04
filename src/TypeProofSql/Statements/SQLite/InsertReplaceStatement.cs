using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertReplaceStatement : ReplaceStatement
    {
        public InsertReplaceStatement() { }
        public InsertReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
