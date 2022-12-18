using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.QueryBuilders;

namespace Amorphous
{
    public interface IDSLContext
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
