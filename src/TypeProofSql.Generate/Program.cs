// See https://aka.ms/new-console-template for more information
using TypeProofSql;
using TypeProofSql.SQLite;
using TypeProofSql.Generate;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Statements;
using Dapper;
using TypeProofSql.Generate.Generators;
using CommandDotNet;
using TypeProofSql.Columns;
using TypeProofSql.Statements.SQLite;

public class Program
{
    public static int Main(string[] args)
    {
        //var appSett = new AppSettings()
        //{

        //};
        //return new AppRunner<Program>(appSett).Run(args);

        Console.WriteLine("Hello, World!");

        try
        {
            //SQLiteGenerator generator = new SQLiteGenerator(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;");
            //generator.Generate();
        }
        catch (Exception ex) { }

        TypeProofSql.SQLiteDSLContext dslCtxt = new SQLiteDSLContext();

        var qall = dslCtxt
            .Select()
            .Distinct()
            .All()
            .From<Tbl_Cards>()
            .QueryBuilder
            .BuildPreparedStatement();

        var et = dslCtxt
            .Update<Tbl_Cards>()
            .Set<Tbl_Cards>(new[] { Tbl_Cards.Name().Value("hi") })
            .Where(Tbl_Cards.Name().Equal("test"))
            .QueryBuilder
            .BuildPreparedStatement();

        var ts = dslCtxt
            .Select(Tbl_Cards.Id(), Tbl_Cards.Name(), Tbl_Cards.Form().As("test"))
            .From<Tbl_Cards>()
            .Where(Tbl_Cards.Id().Greater(10))
            .OrderBy(Tbl_Cards.Id())
            .Limit(50)
            .QueryBuilder
            .BuildPreparedStatement();

        var pppp = dslCtxt
            .With()
            .Recursive<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
            .As()
            .Not()
            .Materialized(dslCtxt
                .Select()
                .Distinct(Tbl_Cards.Id())
                .From<Tbl_Cards>()
                .UnionAll(dslCtxt
                    .Select(Tbl_Cards.Id())
                    .From<Tbl_Cards>()
                    .QueryBuilder)
                .QueryBuilder)
            .QueryBuilder
            .BuildPreparedStatement();

        var sub = dslCtxt
            .With()
            .Recursive<Tbl_With>(Tbl_With.Id())
            .As()
            .Not()
            .Materialized(dslCtxt
                .Select()
                .Distinct(Tbl_Cards.Id())
                .From<Tbl_Cards>()
                .UnionAll(dslCtxt
                    .Select(Tbl_Cards.Id())
                    .From<Tbl_Cards>()
                    .QueryBuilder)
                .QueryBuilder)
            .QueryBuilder
            .BuildPreparedStatement();

        System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
        for (int i = 0; i < 1; i++)
        {
            sub = dslCtxt
                .With<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                .As(dslCtxt.Select(Tbl_Cards.Id()).From<Tbl_Cards>().QueryBuilder)
                .With<Tbl_With>(Tbl_With.Id(), Tbl_With.Name())
                .As(dslCtxt.Select(Tbl_Cards.Id()).From<Tbl_Cards>().QueryBuilder)
                .Select(Tbl_With.Id())
                .From<Tbl_With>()
                .QueryBuilder
                .BuildPreparedStatement();
        }
        stopwatch.Stop();

        using (Microsoft.Data.Sqlite.SqliteConnection sqliteConnection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;"))
        {
            var dapRes = sqliteConnection.Query(ts.Statement, param: ts.Parameters);
        }


        var sql = dslCtxt
            .Select(new Table1.Column1().As("hello"), new Table1.Column1(), new Table1.Column2().As("int"))
            .From<Table1>()
            .Where(new Table1.Column1().Equal("hello"))
            .And(new Table1.Column1().Equal("hello2"))
            .And(new Table1.Column1().In(new[] { "1", "2" }))
            .And(new Table1.Column2().Greater(2))
            .And(new Table1.Column2().IsNull())
            .And(new Table1.Column2().LesserOrEqual(3))
            .Or(new Table1.Column2().Greater(2))
            .GroupBy(new Table1.Column1())
            .OrderBy(new Table1.Column1().Asc(), new Table1.Column1().Desc(), new Table1.Column2().Asc(), new Table1.Column2().Desc())
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Select()
            .All()
            .From<Table1>()
            .InnerJoin<Table1, Table2>()
            .On(new Table1.Column1(), new Table2.Column2())
            .Where(new Table1.Column1().Equal("sdf"))
            .Limit(20)
            .Offset(5)
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Select(new Table1.Column2().Count())
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Select()
            .All()
            .From<Table1>()
            .WhereGroup(s =>
            {
                var g = new ConditionalGroupStatement(s.QueryBuilder)
                {
                    conditionalGroupStatements = new List<ConditionalGroupStatement>()
                    {
                       new ConditionalGroupStatement(s.QueryBuilder, new Table1.Column2().Greater(2)).And(new Table1.Column2().LesserOrEqual(10)),
                       new OrGroupStatement(s.QueryBuilder, new Table1.Column2().Greater(2)).Or(new Table1.Column2().LesserOrEqual(10)),
                       new AndGroupStatement(s.QueryBuilder, new Table1.Column2().Greater(2)).Or(new Table1.Column2().LesserOrEqual(10)),
                    }
                };

                return g;
            })
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Delete()
            .From<Table1>()
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Insert()
            .Into<Table1>()
            .Values(new Table1.Column1().Value("hi"), new Table1.Column2().Value(234))
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        sql = dslCtxt
            .Update<Table1>()
            .Set(new Table1.Column1().Value("update"), new Table1.Column2().Value(234))
            .Where(new Table1.Column1().Equal("new"))
            .QueryBuilder
            .Build();
        Console.WriteLine(sql);

        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        var val = 2;
        var sql2 = "SELECT column1 as hello, column1, column2 as int FROM Table1 WHERE column1 = 'hello'" + val;

        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);


        Console.WriteLine(sql);

        return 0;
    }

    public enum DataBase
    {
        SQLite
    }

    // generate SQLite "Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;" "C:\temp\sqlgen"

    [Command("scheme", Description = "Generates code based on database details to use with Typesafe library.")]
    public async Task Scheme(
        [Operand("database", Description = "Database provider - needs to be supported, e.g. SQLite.")]
        DataBase dataBase,
        [Operand("connectionString", Description = "Full qualified connection string for database access.")]
        string connectionString)
    {
        // Get generator based on database provider
        IGenerator generator;
        switch (dataBase)
        {
            case DataBase.SQLite:
                generator = new SQLiteGenerator(connectionString);
                break;
            default:
                throw new NotImplementedException($"Database provider '{dataBase}' not yet supported!");
        }

        // We first generate the code
        //var generatedCode = await generator.Generate();

        //// Write to console output
        //ConsoleTables.ConsoleTable consoleTable = new ConsoleTables.ConsoleTable(
        //    new ConsoleTables.ConsoleTableOptions() { 
        //        Columns = new string[] { "" }
        //    });
        //foreach (var genCode in generatedCode)
        //{
        //    consoleTable.AddRow(genCode.Value.);
        //}

        //consoleTable.Write();
    }

    [Command("generate", Description = "Generates code based on database details to use with Typesafe library.")]
    public async Task Generate(
        [Operand("database", Description = "Database provider - needs to be supported, e.g. SQLite.")]
        DataBase dataBase,
        [Operand("connectionString", Description = "Full qualified connection string for database access.")]
        string connectionString, 
        [Operand("targetDir", Description = "Directory name and path to store generated files in.")]
        string targetDir, 
        [Option(Description = "Optional - Namespace of generated classes.")]
        string nspace = "")
    {
        // Get generator based on database provider
        IGenerator generator;
        switch (dataBase)
        {
            case DataBase.SQLite:
                generator = new SQLiteGenerator(connectionString);
                break;
            default:
                throw new NotImplementedException($"Database provider '{dataBase}' not yet supported!");
        }

        // We first generate the code
        var generatedCode = await generator.Generate(nspace);

        // Then we create the directory - if necessary
        var directoryInfo = new DirectoryInfo(targetDir);
        if (directoryInfo.Exists == false)
        {
            directoryInfo.Create();
        }

        // No write generated code to files
        foreach (var genCode in generatedCode)
        {
            var fileName = Path.Combine(directoryInfo.FullName, $"Typesafe.{genCode.Key}.cs");
            await File.WriteAllTextAsync(fileName, genCode.Value);
        }
    }
}