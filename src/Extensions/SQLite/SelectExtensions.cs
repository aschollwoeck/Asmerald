using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;
using TypeProofSql.Columns;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static SelectColumnsStatement Select(this AsSelectStatement stmt, params ISelectColumn[] selectColumns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, selectColumns);
        }

        public static SelectColumnsStatement Select(this MaterializedStatement stmt, params ISelectColumn[] selectColumns)
        {
            return new SelectColumnsStatement(stmt.QueryBuilder, selectColumns);
        }

        public static SelectStatement Select(this AsSelectStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }

        public static SelectStatement Select(this MaterializedStatement stmt)
        {
            return new SelectStatement(stmt.QueryBuilder);
        }

        public static DistinctStatement Distinct(this SelectStatement stmt)
        {
            return new DistinctStatement(stmt.QueryBuilder);
        }

        public static DistinctColumnsStatement Distinct(this SelectStatement stmt, params ISelectColumn[] selectColumns)
        {
            return new DistinctColumnsStatement(stmt.QueryBuilder, selectColumns);
        }

        public static AllStatement All(this SelectStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }

        public static AllStatement All(this DistinctStatement stmt)
        {
            return new AllStatement(stmt.QueryBuilder);
        }
    }
}
