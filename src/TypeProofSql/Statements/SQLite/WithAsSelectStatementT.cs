using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WithAsSelectStatement<T> : WithAsSelectStatement
        where T : ITable, new()
    {
        public WithAsSelectStatement(IQueryBuilder queryBuilder, IQueryBuilder subQuery)
            : base(queryBuilder, new T(), subQuery)
        {
        }
    }
}
