using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.QueryBuilders;

namespace Asmerald
{
    public interface IDSLContext
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
