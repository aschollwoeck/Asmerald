using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.QueryBuilders;

namespace Asmerald.Statements
{
    public interface IQueryBuilderContainer
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
