using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.Columns
{
    public interface IOrderBy
    {
        IOrderByColumn Asc();

        IOrderByColumn Desc();
    }
}
