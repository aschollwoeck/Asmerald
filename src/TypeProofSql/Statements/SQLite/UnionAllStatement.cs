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
    public class UnionAllStatement : CompoundStatement
    {
        public UnionAllStatement(IQueryBuilder queryBuilder, IQueryBuilder subQueryBuilder)
            : base(queryBuilder, subQueryBuilder)
        {
        }
    }
}
