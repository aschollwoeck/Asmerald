using Asmerald.Generate.Generators;

namespace Asmerald.Generate
{
    public interface IGenerator
    {
        (List<TableGenerate>, List<StoredProcedureGenerate>, List<FunctionGenerate>) Generate();
    }
}
