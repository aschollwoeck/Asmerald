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
    public class FromSubQueryStatement<T> : FromSubQueryStatement
        where T : ITable, new()
    {
        public FromSubQueryStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder, new T())
        {
        }
    }
}
