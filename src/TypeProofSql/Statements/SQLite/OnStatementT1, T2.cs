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
    public class OnStatement<T1, T2> : OnStatement
        where T1 : ITable, new()
        where T2 : ITable, new()
    {
        public OnStatement(IQueryBuilder queryBuilder, ISelectColumn<T1> left, ISelectColumn<T2> right)
            : base(queryBuilder, left, right)
        {
        }
    }
}
