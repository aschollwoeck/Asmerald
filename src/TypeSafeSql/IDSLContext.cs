using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql
{
    public interface IDSLContext
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
