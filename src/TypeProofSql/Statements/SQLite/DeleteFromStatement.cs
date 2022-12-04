using System.Collections.Generic;
using TypeProofSql.Columns;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class DeleteFromStatement : FromStatement
    {
        public DeleteFromStatement() { }
        public DeleteFromStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder, table)
        {
        }
    }
}
