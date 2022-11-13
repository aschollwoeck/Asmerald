using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;

namespace TypeProofSql
{
    public class SQLiteDSLContext : IDSLContext
    {
        public IQueryBuilder QueryBuilder { get; private set; }

        public SQLiteDSLContext()
        {
            this.QueryBuilder = new SQLiteQueryBuilder();
        }

        public SQLiteDSLContext SubQuery()
        {
            return new SQLiteDSLContext();
        }

        public ConditionalGroupStatement Group(ConditionalExpression expression)
        {
            return new ConditionalGroupStatement(SubQuery().QueryBuilder, expression);
        }

        public ConditionalGroupStatement Group(ConditionalStatement statement)
        {
            var g = new ConditionalGroupStatement(SubQuery().QueryBuilder);
            g.AddStatement(statement);
            return g;
        }
        
        public ConditionalGroupStatement Group(IEnumerable<ConditionalStatement> statements)
        {
            var g = new ConditionalGroupStatement(SubQuery().QueryBuilder);
            foreach (var stmt in statements)
            {
                g.AddStatement(stmt);
            }
            return g;
        }

        public ConditionalGroupStatement Group(ConditionalGroupStatement groupStatement)
        {
            var g = new ConditionalGroupStatement(SubQuery().QueryBuilder);
            g.AddGroup(groupStatement);
            return g;
        }

        public ConditionalStatement Stmt(ConditionalExpression conditionalExpression)
        {
            return new ConditionalStatement(conditionalExpression);
        }
    }
}
