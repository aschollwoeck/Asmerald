using System;
using System.Collections.Generic;
using System.Text;

namespace Germanium.Columns
{
    public interface IOrderBy
    {
        IOrderByColumn Asc();

        IOrderByColumn Desc();
    }
}
