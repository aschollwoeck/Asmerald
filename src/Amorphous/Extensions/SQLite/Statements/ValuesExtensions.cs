using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.QueryBuilders;
using Amorphous.Statements;
using Amorphous.Statements.SQLite;

namespace Amorphous.SQLite
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
