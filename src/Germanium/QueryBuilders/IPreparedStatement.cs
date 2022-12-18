using System;
using System.Collections.Generic;
using System.Text;

namespace Germanium.QueryBuilders
{
    public interface IPreparedStatement
    {
        string Statement { get; }
        Dictionary<string, object> Parameters { get; }
    }
}
