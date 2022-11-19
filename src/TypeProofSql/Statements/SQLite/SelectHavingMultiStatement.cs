using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class SelectHavingMultiStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public List<ConditionalStatement> ConditionalStatements { get; private set; }
        public SelectHavingMultiStatement() { }
        public SelectHavingMultiStatement(IQueryBuilder queryBuilder, List<ConditionalStatement> conditionalStatements)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.ConditionalStatements = conditionalStatements;
        }
    }
}
