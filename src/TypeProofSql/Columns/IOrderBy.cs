using System;
using System.Collections.Generic;
using System.Text;

namespace TypeProofSql.Columns
{
    public interface IOrderBy
    {
        IOrderByColumn Asc();

        IOrderByColumn Desc();
    }
}
