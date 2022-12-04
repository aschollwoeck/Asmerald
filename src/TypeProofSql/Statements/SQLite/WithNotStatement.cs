using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WithNotStatement : NotStatement
    {
        public WithNotStatement() { }
        public WithNotStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
