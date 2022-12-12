using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.QueryBuilders;

namespace TypeProofSql.Statements
{
    public interface IStatement
    {
        IQueryBuilder QueryBuilder { get; }
    }
}
