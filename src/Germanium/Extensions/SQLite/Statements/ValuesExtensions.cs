using System;
using System.Collections.Generic;
using System.Linq;
using Germanium.Columns;
using Germanium.Expressions;
using Germanium.QueryBuilders;
using Germanium.Statements;
using Germanium.Statements.SQLite;

namespace Germanium.SQLite
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
