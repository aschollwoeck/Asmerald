using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertAbortStatement : AbortStatement
    {
        public InsertAbortStatement() { }
        public InsertAbortStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
