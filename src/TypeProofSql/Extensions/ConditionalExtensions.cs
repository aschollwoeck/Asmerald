using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using System.Linq;
using TypeProofSql.Statements.SQLite;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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


        // Expression --> List<Statement>
        public static List<ConditionalStatement> And(this ConditionalStatement condStmt, ConditionalExpression expression)
        {
            List<ConditionalStatement> res = new List<ConditionalStatement>();
            res.Add(condStmt);
            res.Add(new AndStatement(null, expression));

            return res;
        }
        public static List<ConditionalStatement> Or(this ConditionalStatement condStmt, ConditionalExpression expression)
        {
            List<ConditionalStatement> res = new List<ConditionalStatement>();
            res.Add(condStmt);
            res.Add(new OrStatement(null, expression));

            return res;
        }

        // Expression --> List<Statement>
        public static List<ConditionalStatement> And(this IEnumerable<ConditionalStatement> statements, ConditionalExpression expression)
        {
            List<ConditionalStatement> res = new List<ConditionalStatement>(statements);
            res.Add(new AndStatement(null, expression));

            return res;
        }
        public static List<ConditionalStatement> Or(this IEnumerable<ConditionalStatement> statements, ConditionalExpression expression)
        {
            List<ConditionalStatement> res = new List<ConditionalStatement>(statements);
            res.Add(new OrStatement(null, expression));

            return res;
        }

        // Statement --> Group
        public static ConditionalGroupStatement And(this ConditionalStatement statement, ConditionalGroupStatement groupStatement)
        {
            var g = new AndGroupStatement(statement.QueryBuilder);
            g.AddGroup(groupStatement);
            return g;
        }
        public static ConditionalGroupStatement Or(this ConditionalStatement statement, ConditionalGroupStatement groupStatement)
        {
            var g = new OrGroupStatement(statement.QueryBuilder);
            g.AddGroup(groupStatement);
            return g;
        }
        public static ConditionalGroupStatement And(this IEnumerable<ConditionalStatement> statements, ConditionalGroupStatement groupStatement)
        {
            var g = new AndGroupStatement();
            g.AddGroup(groupStatement);
            return g;
        }
        public static ConditionalGroupStatement Or(this IEnumerable<ConditionalStatement> statements, ConditionalGroupStatement groupStatement)
        {
            var g = new OrGroupStatement();
            g.AddGroup(groupStatement);
            return g;
        }


        // Group --> Statement
        public static ConditionalStatement And(this ConditionalGroupStatement condStmt, ConditionalExpression expression)
        {
            return new AndStatement(condStmt.QueryBuilder, expression);

            //var g = new AndGroupStatement(condStmt.QueryBuilder);
            //foreach (var statement in statements)
            //{
            //    g.AddStatement(statement);
            //}
            //return g;
        }
        public static ConditionalStatement Or(this ConditionalGroupStatement condStmt, ConditionalExpression expression)
        {
            return new OrStatement(condStmt.QueryBuilder, expression);
            //var g = new OrGroupStatement(condStmt.QueryBuilder);
            //foreach (var statement in statements)
            //{
            //    g.AddStatement(statement);
            //}
            //return g;
        }
    }
}
