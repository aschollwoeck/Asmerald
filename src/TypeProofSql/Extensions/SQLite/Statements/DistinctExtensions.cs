using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlDistinctExtensions
    {
        public static DistinctStatement Distinct(this SelectStatement stmt)
        {
            return new DistinctStatement(stmt.QueryBuilder);
        }
        public static DistinctColumnsStatement Distinct(this SelectStatement stmt, params ISelectExpression[] columns)
        {
            return new DistinctColumnsStatement(stmt.QueryBuilder, columns);
        }
    }
}
