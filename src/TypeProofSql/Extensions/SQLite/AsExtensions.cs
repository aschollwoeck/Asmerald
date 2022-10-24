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
    public static partial class TypeProofSqlAsExtensions
    {
        public static TableAsStatement As(this FromStatement stmt, string alias)
        {
            return new TableAsStatement(stmt.QueryBuilder, alias);
        }
        public static JoinAsStatement As(this JoinStatement stmt, string alias)
        {
            return new JoinAsStatement(stmt.QueryBuilder, alias);
        }
        public static AsSelectStatement As(this RecursiveStatement stmt, IQueryBuilder subQuery)
        {
            return new AsSelectStatement(stmt.QueryBuilder, subQuery);
        }
        public static AsSelectStatement As(this WithTableStatement stmt, IQueryBuilder subQuery)
        {
            return new AsSelectStatement(stmt.QueryBuilder, subQuery);
        }
        public static AsSelectStatement As(this WithTableAdditionalStatement stmt, IQueryBuilder subQuery)
        {
            return new AsSelectStatement(stmt.QueryBuilder, subQuery);
        }
        public static AsStatement As(this RecursiveStatement stmt)
        {
            return new AsStatement(stmt.QueryBuilder);
        }
        public static AsStatement As(this WithTableStatement stmt)
        {
            return new AsStatement(stmt.QueryBuilder);
        }
    }
}
