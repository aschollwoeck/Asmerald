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
    public class UpdateFrom<T>Statement : UpdateFromStatement
        where T : ITable, new()
    {
        public UpdateFrom(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T())
        {
        }
    }
}
