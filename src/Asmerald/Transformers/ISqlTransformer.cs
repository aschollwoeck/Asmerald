using System;
using System.Collections.Generic;
using System.Text;
using Asmerald.Statements;

namespace Asmerald
{
    public interface ISqlTransformer
    {
        Dictionary<string, object> Transform(IStatement statement, StringBuilder builder, ref int paraCount);
        Dictionary<string, object> Transform(IEnumerable<IStatement> statement, StringBuilder builder);
    }
}
