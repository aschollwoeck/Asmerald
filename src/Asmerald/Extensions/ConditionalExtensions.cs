using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using System.Linq;
using Asmerald.Statements.SQLite;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Asmerald.SQLite
{
    public static partial class TypeProofSqlExtensions
    {
        // Expression --> List<Statement>
        public static List<ConditionalStatement> And(this ConditionalExpression expression, ConditionalExpression conditionalExpression)
        {
            return new List<ConditionalStatement>() 
            {
                new ConditionalStatement(expression),
                new AndStatement(conditionalExpression) 
            };
        }
        public static List<ConditionalStatement> Or(this ConditionalExpression expression, ConditionalExpression conditionalExpression)
        {
            return new List<ConditionalStatement>()
            {
                new ConditionalStatement(expression),
                new OrStatement(conditionalExpression)
            };
        }

        // Statement --> Statement
        public static List<ConditionalStatement> And(this List<ConditionalStatement> conditionalStatements, ConditionalExpression conditionalExpression)
        {
            var s = new List<ConditionalStatement>(conditionalStatements);
            s.Add(new AndStatement(conditionalExpression));
            return s;
        }
        public static List<ConditionalStatement> Or(this List<ConditionalStatement> conditionalStatements, ConditionalExpression conditionalExpression)
        {
            var s = new List<ConditionalStatement>(conditionalStatements);
            s.Add(new OrStatement(conditionalExpression));
            return s;
        }

        // Expression --> Group
        public static List<ConditionalGroupStatement> Group(this ConditionalExpression expression)
        {
            return new List<ConditionalGroupStatement>() { new ConditionalGroupStatement(expression) };
        }

        // Statement --> Group
        public static List<ConditionalGroupStatement> Group(this ConditionalStatement statement)
        {
            var g = new ConditionalGroupStatement();
            g.AddStatement(statement);
            return new List<ConditionalGroupStatement>() { g };
        }
        public static List<ConditionalGroupStatement> Group(this List<ConditionalStatement> conditionalStatements)
        {
            var g = new ConditionalGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            return new List<ConditionalGroupStatement>() { g };
        }

        // Group --> Group
        public static List<ConditionalGroupStatement> And(this List<ConditionalGroupStatement> groupStatements, ConditionalGroupStatement conditionalGroupStatement)
        {
            var g = new List<ConditionalGroupStatement>(groupStatements);
            g.Add(new AndGroupStatement(conditionalGroupStatement));
            return g;
        }
        public static List<ConditionalGroupStatement> Or(this List<ConditionalGroupStatement> groupStatements, ConditionalGroupStatement conditionalGroupStatement)
        {
            var g = new List<ConditionalGroupStatement>(groupStatements);
            g.Add(new OrGroupStatement(conditionalGroupStatement));
            return g;
        }
        public static List<ConditionalGroupStatement> And(this List<ConditionalGroupStatement> groupStatements, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            var res = new List<ConditionalGroupStatement>(groupStatements);
            var g = new AndGroupStatement();
            conditionalGroupStatements.ForEach(cgs => g.AddGroup(cgs));
            res.Add(g);
            return res;
        }
        public static List<ConditionalGroupStatement> Or(this List<ConditionalGroupStatement> groupStatements, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            var res = new List<ConditionalGroupStatement>(groupStatements);
            var g = new OrGroupStatement();
            conditionalGroupStatements.ForEach(cgs => g.AddGroup(cgs));
            res.Add(g);
            return res;
        }

        // Group --> Expression
        public static List<ConditionalGroupStatement> And(this List<ConditionalGroupStatement> groupStatements, ConditionalExpression expression)
        {
            var l = new List<ConditionalGroupStatement>(groupStatements);
            var g = new AndGroupStatement(expression);
            l.Add(g);
            return l;
        }
        public static List<ConditionalGroupStatement> Or(this List<ConditionalGroupStatement> groupStatement, ConditionalExpression expression)
        {
            var l = new List<ConditionalGroupStatement>(groupStatement);
            var g = new OrGroupStatement(expression);
            l.Add(g);
            return l;
        }

        // Group --> Expression
        public static List<ConditionalGroupStatement> And(this ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression)
        {
            var g = new AndGroupStatement(conditionalExpression);

            var res = new List<ConditionalGroupStatement>();
            res.Add(groupStatement);
            res.Add(g);

            return res;
        }
        public static List<ConditionalGroupStatement> Or(this ConditionalGroupStatement groupStatement, ConditionalExpression conditionalExpression)
        {
            var g = new OrGroupStatement(conditionalExpression);

            var res = new List<ConditionalGroupStatement>();
            res.Add(groupStatement);
            res.Add(g);

            return res;
        }

        // Group --> Statement
        public static List<ConditionalGroupStatement> And(this ConditionalGroupStatement groupStatement, List<ConditionalStatement> conditionalStatements)
        {
            var g = new AndGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            return new List<ConditionalGroupStatement>() { g };
        }
        public static List<ConditionalGroupStatement> Or(this ConditionalGroupStatement groupStatement, List<ConditionalStatement> conditionalStatements)
        {
            var g = new OrGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            return new List<ConditionalGroupStatement>() { g };
        }
        public static List<ConditionalGroupStatement> And(this List<ConditionalGroupStatement> groupStatements, List<ConditionalStatement> conditionalStatements)
        {
            var g = new AndGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            var res = new List<ConditionalGroupStatement>(groupStatements);
            res.Add(g);

            return res;
        }
        public static List<ConditionalGroupStatement> Or(this List<ConditionalGroupStatement> groupStatements, List<ConditionalStatement> conditionalStatements)
        {
            var g = new OrGroupStatement();
            conditionalStatements.ForEach(cs => g.AddStatement(cs));
            var res = new List<ConditionalGroupStatement>(groupStatements);
            res.Add(g);

            return res;
        }
    }
}
