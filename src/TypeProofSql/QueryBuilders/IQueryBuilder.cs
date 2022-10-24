using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Statements;

namespace TypeProofSql.QueryBuilders
{
    public interface IQueryBuilder
    {
        IQueryBuilder QueryBuilder { get; }
        void AddStatment(IStatement statement);
        string Build();
        IPreparedStatement BuildPreparedStatement();
    } 
}
