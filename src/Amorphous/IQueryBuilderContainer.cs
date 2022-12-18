using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.QueryBuilders;

namespace Amorphous.Statements
{
    public interface IQueryBuilderContainer
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
