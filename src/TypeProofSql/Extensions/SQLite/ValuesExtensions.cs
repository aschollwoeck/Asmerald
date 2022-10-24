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
        public static ValueStatement Values(this IntoStatement stmt, params ValueExpression[] valueExpressions)
        {
            return new ValueStatement(stmt.QueryBuilder, valueExpressions);
        }
    }
}
