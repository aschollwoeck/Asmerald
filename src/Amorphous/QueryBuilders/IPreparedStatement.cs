using System;
using System.Collections.Generic;
using System.Text;

namespace Amorphous.QueryBuilders
{
    public interface IPreparedStatement
    {
        string Statement { get; }
        Dictionary<string, object> Parameters { get; }
    }
}
