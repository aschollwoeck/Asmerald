using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
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
