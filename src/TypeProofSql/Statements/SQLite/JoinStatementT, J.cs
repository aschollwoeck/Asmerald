using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;
using TypeProofSql.Statements;

namespace TypeProofSql.Statements.SQLite
{
    public class JoinStatement<T, J> : JoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public JoinStatement(IQueryBuilder queryBuilder, T left, J right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
