using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class InsertFailStatement : FailStatement
    {
        public InsertFailStatement() { }
        public InsertFailStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
