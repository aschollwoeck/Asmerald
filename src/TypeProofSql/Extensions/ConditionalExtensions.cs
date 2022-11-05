using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        //public static ConditionalGroupStatement WhereGroup(this FromStatement stmt, Func<FromStatement, ConditionalGroupStatement> func)
        //{
        //    var groupStmt = func.Invoke(stmt);

        //    var whereStmt = new WhereStatement(stmt.QueryBuilder, null);
        //    whereStmt.AddGroup(groupStmt);

        //    return whereStmt;
        //}

        //public static ConditionalGroupStatement WhereGroup(this OnStatement stmt, Func<OnStatement, ConditionalGroupStatement> func)
        //{
        //    var groupStmt = func.Invoke(stmt);

        //    var whereStmt = new WhereStatement(stmt.QueryBuilder, null);
        //    whereStmt.conditionalGroupStatements.Add(groupStmt);

        //    return whereStmt;
        //}

        //public static ConditionalGroupStatement WhereGroup(this NonConditionalJoinStatement stmt, Func<NonConditionalJoinStatement, ConditionalGroupStatement> func)
        //{
        //    var groupStmt = func.Invoke(stmt);

        //    var whereStmt = new WhereStatement(stmt.QueryBuilder, null);
        //    whereStmt.conditionalGroupStatements.Add(groupStmt);

        //    return whereStmt;
        //}

        //public static ConditionalGroupStatement WhereGroup(this SetStatement stmt, Func<SetStatement, ConditionalGroupStatement> func)
        //{
        //    var groupStmt = func.Invoke(stmt);

        //    var whereStmt = new WhereStatement(stmt.QueryBuilder, null);
        //    whereStmt.conditionalGroupStatements.Add(groupStmt);

        //    return whereStmt;
        //}

        //public static WhereStatement Where(this FromStatement stmt, ConditionalExpression conditionalExpression)
        //{
        //    return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        //}

        //public static WhereStatement Where(this OnStatement stmt, ConditionalExpression conditionalExpression)
        //{
        //    return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        //}

        //public static WhereStatement Where(this SetStatement stmt, ConditionalExpression conditionalExpression)
        //{
        //    return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        //}

        //public static WhereStatement Where(this NonConditionalJoinStatement stmt, ConditionalExpression conditionalExpression)
        //{
        //    return new WhereStatement(stmt.QueryBuilder, conditionalExpression);
        //}

        public static ConditionalGroupStatement And(this ConditionalGroupStatement condStmt, ConditionalExpression conditionalExpression)
        {
            var stmt = new AndStatement(condStmt.QueryBuilder, condStmt, conditionalExpression);
            return condStmt;
        }

        public static ConditionalGroupStatement Or(this ConditionalGroupStatement condStmt, ConditionalExpression conditionalExpression)
        {
            var stmt = new OrStatement(condStmt.QueryBuilder, condStmt, conditionalExpression);
            return condStmt;
        }
    }
}
