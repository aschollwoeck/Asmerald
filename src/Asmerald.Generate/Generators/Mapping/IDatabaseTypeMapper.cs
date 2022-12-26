namespace Asmerald.Generate.Generators.Mapping
{
    public interface IDatabaseTypeMapper
    {
        Type? Map(string dbColumnType);
    }
}