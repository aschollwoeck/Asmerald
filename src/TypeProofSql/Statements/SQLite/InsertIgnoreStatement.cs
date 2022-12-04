using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertIgnoreStatement : IgnoreStatement
    {
        public InsertIgnoreStatement() { }
        public InsertIgnoreStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
