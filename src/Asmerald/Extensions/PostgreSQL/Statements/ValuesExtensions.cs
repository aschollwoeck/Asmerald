using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.PostgreSQL;

namespace Asmerald.PostgreSQL
{
    public static partial class AsmeraldValuesExtensions
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
