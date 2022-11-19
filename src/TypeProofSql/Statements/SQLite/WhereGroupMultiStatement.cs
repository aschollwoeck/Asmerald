using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class WhereGroupMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalGroupStatement> ConditionalGroupStatements { get; private set; }
        public WhereGroupMultiStatement() { }
        public WhereGroupMultiStatement(IQueryBuilder queryBuilder, List<ConditionalGroupStatement> conditionalGroupStatements)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalGroupStatements = conditionalGroupStatements;
        }
    }
}
