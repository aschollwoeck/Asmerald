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
    public class IntoStatement<T> : IntoStatement
        where T : ITable, new()
    {
        public IntoStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
