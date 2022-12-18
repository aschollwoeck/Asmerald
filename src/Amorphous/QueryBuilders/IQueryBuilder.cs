using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Statements;

namespace Amorphous.QueryBuilders
{
    public interface IQueryBuilder
    {
        IQueryBuilder QueryBuilder { get; }
        void AddStatment(IStatement statement);
        string Build();
        IPreparedStatement BuildPreparedStatement();
    } 
}
