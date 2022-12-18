using System;
using System.Collections.Generic;
using System.Text;

namespace Amorphous.Columns
{
    public interface IOrderBy
    {
        IOrderByColumn Asc();

        IOrderByColumn Desc();
    }
}
