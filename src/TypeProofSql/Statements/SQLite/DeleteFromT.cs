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
    public class DeleteFrom<T>Statement : DeleteFromStatement
        where T : ITable, new()
    {
        public DeleteFrom(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
