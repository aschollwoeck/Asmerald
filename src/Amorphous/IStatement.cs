using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.QueryBuilders;

namespace Amorphous.Statements
{
    public interface IStatement
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
