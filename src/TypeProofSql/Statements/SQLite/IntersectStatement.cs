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
    public class IntersectStatement : CompoundStatement
    {
        public IntersectStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder)
        {
        }
    }
}
