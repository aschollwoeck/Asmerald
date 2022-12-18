using System;
using System.Collections.Generic;
using System.Text;
using Germanium.Statements;

namespace Germanium.QueryBuilders
{
    public interface IQueryBuilder
    {
        IQueryBuilder QueryBuilder { get; }
        void AddStatment(IStatement statement);
        string Build();
        IPreparedStatement BuildPreparedStatement();
    } 
}
