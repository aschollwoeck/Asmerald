using Asmerald.Generate.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate
{
    public interface IGenerator
    {
        List<TableGenerate> Generate();
    }
}
