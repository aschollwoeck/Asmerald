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
        // Expression --> List<Statement>
        public static List<ConditionalStatement> And(this ConditionalExpression expression, ConditionalExpression conditionalExpression)
        {
            return new List<ConditionalStatement>() 
            {
                new ConditionalStatement(expression),
                new ConditionalStatement(conditionalExpression) 
            };
        }
        public static List<ConditionalStatement> Or(this ConditionalExpression expression, ConditionalExpression conditionalExpression)
        {
            return new List<ConditionalStatement>()
            {
                new ConditionalStatement(expression),
                new ConditionalStatement(conditionalExpression)
            };
        }

        // Statement --> Statement
        public static List<ConditionalStatement> And(this List<ConditionalStatement> conditionalStatements, ConditionalExpression conditionalExpression)
        {
            var s = new List<ConditionalStatement>(conditionalStatements);
            s.Add(new AndStatement(null, conditionalExpression));
            return s;
        }
        public static List<ConditionalStatement> Or(this List<ConditionalStatement> conditionalStatements, ConditionalExpression conditionalExpression)
        {
            var s = new List<ConditionalStatement>(conditionalStatements);
            s.Add(new OrStatement(null, conditionalExpression));
            return s;
        }

        // Expression --> Group
        public static ConditionalGroupStatement Group(this ConditionalExpression expression)
        {
            return new ConditionalGroupStatement(expression);
        }

        // Statement --> Group
        public static ConditionalGroupStatement Group(this ConditionalStatement statement)
        {
            var g = new ConditionalGroupStatement();
            g.AddStatement(statement);
            return g;
        }
        public static ConditionalGroupStatement Group(this List<ConditionalStatement> conditionalStatements)
        {
            var g = new ConditionalGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            return g;
        }

        // Group --> Group
        public static ConditionalGroupStatement And(this ConditionalGroupStatement groupStatement, ConditionalGroupStatement conditionalGroupStatement)
        {
            return new ConditionalGroupStatement();
        }
        public static ConditionalGroupStatement Or(this ConditionalGroupStatement groupStatement, ConditionalGroupStatement conditionalGroupStatement)
        {
            return new ConditionalGroupStatement();
        }

        // Group --> Expression
        public static ConditionalGroupStatement And(this ConditionalGroupStatement groupStatement, ConditionalExpression expression)
        {
            return new ConditionalGroupStatement();
        }
        public static ConditionalGroupStatement Or(this ConditionalGroupStatement groupStatement, ConditionalExpression expression)
        {
            return new ConditionalGroupStatement();
        }

        // Group --> Statement
        public static ConditionalGroupStatement And(this ConditionalGroupStatement groupStatement, ConditionalStatement conditionalStatement)
        {
            return new ConditionalGroupStatement();
        }
        public static ConditionalGroupStatement Or(this ConditionalGroupStatement groupStatement, ConditionalStatement conditionalStatement)
        {
            return new ConditionalGroupStatement();
        }
        public static ConditionalGroupStatement And(this ConditionalGroupStatement groupStatement, List<ConditionalStatement> conditionalStatements)
        {
            return new ConditionalGroupStatement();
        }
        public static ConditionalGroupStatement Or(this ConditionalGroupStatement groupStatement, List<ConditionalStatement> conditionalStatements)
        {
            return new ConditionalGroupStatement();
        }


        //public static List<ConditionalStatement> And(this ConditionalStatement condStmt, ConditionalExpression expression)
        //{
        //    List<ConditionalStatement> res = new List<ConditionalStatement>();
        //    res.Add(condStmt);
        //    res.Add(new AndStatement(null, expression));

        //    return res;
        //}
        //public static List<ConditionalStatement> Or(this ConditionalStatement condStmt, ConditionalExpression expression)
        //{
        //    List<ConditionalStatement> res = new List<ConditionalStatement>();
        //    res.Add(condStmt);
        //    res.Add(new OrStatement(null, expression));

        //    return res;
        //}

        //// Expression --> List<Statement>
        //public static List<ConditionalStatement> And(this IEnumerable<ConditionalStatement> statements, ConditionalExpression expression)
        //{
        //    List<ConditionalStatement> res = new List<ConditionalStatement>(statements);
        //    res.Add(new AndStatement(null, expression));

        //    return res;
        //}
        //public static List<ConditionalStatement> Or(this IEnumerable<ConditionalStatement> statements, ConditionalExpression expression)
        //{
        //    List<ConditionalStatement> res = new List<ConditionalStatement>(statements);
        //    res.Add(new OrStatement(null, expression));

        //    return res;
        //}

        //// Statement --> Group
        //public static ConditionalGroupStatement And(this ConditionalStatement statement, ConditionalGroupStatement groupStatement)
        //{
        //    var g = new AndGroupStatement(statement.QueryBuilder);
        //    g.AddGroup(groupStatement);
        //    return g;
        //}
        //public static ConditionalGroupStatement Or(this ConditionalStatement statement, ConditionalGroupStatement groupStatement)
        //{
        //    var g = new OrGroupStatement(statement.QueryBuilder);
        //    g.AddGroup(groupStatement);
        //    return g;
        //}
        //public static ConditionalGroupStatement And(this IEnumerable<ConditionalStatement> statements, ConditionalGroupStatement groupStatement)
        //{
        //    var g = new AndGroupStatement();
        //    g.AddGroup(groupStatement);
        //    return g;
        //}
        //public static ConditionalGroupStatement Or(this IEnumerable<ConditionalStatement> statements, ConditionalGroupStatement groupStatement)
        //{
        //    var g = new OrGroupStatement();
        //    g.AddGroup(groupStatement);
        //    return g;
        //}


        //// Group --> Statement
        //public static ConditionalStatement And(this ConditionalGroupStatement condStmt, ConditionalExpression expression)
        //{
        //    return new AndStatement(condStmt.QueryBuilder, expression);

        //    //var g = new AndGroupStatement(condStmt.QueryBuilder);
        //    //foreach (var statement in statements)
        //    //{
        //    //    g.AddStatement(statement);
        //    //}
        //    //return g;
        //}
        //public static ConditionalStatement Or(this ConditionalGroupStatement condStmt, ConditionalExpression expression)
        //{
        //    return new OrStatement(condStmt.QueryBuilder, expression);
        //    //var g = new OrGroupStatement(condStmt.QueryBuilder);
        //    //foreach (var statement in statements)
        //    //{
        //    //    g.AddStatement(statement);
        //    //}
        //    //return g;
        //}
    }
}
