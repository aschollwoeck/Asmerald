using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public interface IQueryBuilderContainer
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
