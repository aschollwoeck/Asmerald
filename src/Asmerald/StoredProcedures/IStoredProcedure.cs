using Asmerald.QueryBuilders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asmerald.StoredProcedures
{
    public interface IStoredProcedure
    {
        string Name();
        List<(string, object)> GetParameters();
    }
}
