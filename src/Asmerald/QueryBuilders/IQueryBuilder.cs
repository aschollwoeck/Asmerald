using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Statements;

namespace Asmerald.QueryBuilders
{
    public interface IQueryBuilder
    {
        IQueryBuilder QueryBuilder { get; }
        void AddStatment(IStatement statement);
        string Build();
        IPreparedStatement BuildPreparedStatement();
    } 
}
