using System;
using System.Collections.Generic;
using System.Text;
using Germanium.QueryBuilders;

namespace Germanium.Statements
{
    public interface IQueryBuilderContainer
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
