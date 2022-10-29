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
    public class JoinStatement<T1, T2> : JoinStatement
        where T1 : ITable, new()
        where T2 : ITable, new()
    {
        public JoinStatement(IQueryBuilder queryBuilder, T1 left, T2 right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
