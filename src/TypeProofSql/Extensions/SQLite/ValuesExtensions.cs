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
    public static partial class TypeProofSqlValuesExtensions
    {
        public static InsertValuesStatement Values<T>(this IntoStatement<T> stmt, params ValueExpression[] valueExpressions)
            where T : ITable, new()
        {
            return new InsertValuesStatement(stmt.QueryBuilder, valueExpressions);
        }
        public static InsertValuesStatement Values(this IntoAsStatement stmt, params ValueExpression[] valueExpressions)
        {
            return new InsertValuesStatement(stmt.QueryBuilder, valueExpressions);
        }
        public static DefaultValuesStatement Values(this DefaultStatement stmt)
        {
            return new DefaultValuesStatement(stmt.QueryBuilder);
        }
    }
}
