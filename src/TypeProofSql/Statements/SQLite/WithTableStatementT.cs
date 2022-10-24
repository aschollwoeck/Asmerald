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
    public class WithTableStatement<T> : WithTableStatement
        where T : ITable, new()
    {
        public WithTableStatement(IQueryBuilder queryBuilder, IEnumerable<ISelectColumn> selectColumns)
            : base(queryBuilder, new T(), selectColumns)
        {
        }
    }
}
