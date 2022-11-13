using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OrGroupStatement : ConditionalGroupStatement
    {
        public OrGroupStatement() { }
        public OrGroupStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
