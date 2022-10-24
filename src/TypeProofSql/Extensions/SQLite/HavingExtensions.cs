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
    public static partial class TypeProofSqlHavingExtensions
    {
        public static HavingStatement Having(this GroupByStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new HavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
        public static HavingStatement Having(this WhereStatement stmt, ConditionalExpression conditionalExpression)
        {
            return new HavingStatement(stmt.QueryBuilder, conditionalExpression);
        }
    }
}
