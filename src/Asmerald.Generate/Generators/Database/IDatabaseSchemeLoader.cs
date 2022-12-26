namespace Asmerald.Generate.Generators.Database
{
    public interface IDatabaseSchemeLoader
    {
        List<DatabaseSchema> LoadTables();
        List<TableSchema> LoadColumns(string table);
    }
}