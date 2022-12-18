using System;
using System.Collections.Generic;
using System.Text;
using Germanium.QueryBuilders;

namespace Germanium
{
    public interface IDSLContext
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
