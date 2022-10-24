using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.Join;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        public static HavingStatement Having(this GroupByStatement groupByStmt, ConditionalExpression conditionalExpression)
        {
            return new HavingStatement(groupByStmt.QueryBuilder, conditionalExpression);
        }

        public static HavingStatement Having(this WhereStatement whereStmt, ConditionalExpression conditionalExpression)
        {
            return new HavingStatement(whereStmt.QueryBuilder, conditionalExpression);
        }
    }
}
