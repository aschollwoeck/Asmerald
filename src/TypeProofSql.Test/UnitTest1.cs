using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dapper;
using System.Linq;
using System.Diagnostics;
using TypeProofSql.SQLite;
using System;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dbConnection = new Microsoft.Data.Sqlite.SqliteConnection(@"Data Source=C:\Users\Alexander\Desktop\Digillection\digillection.sqlite3;");
            dbConnection.Open();

            var res2 = dbConnection.Query("SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit",
    param: new { idGr = 10, limit = 50 })
    .ToList();

            int c = 100;

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < c; i++)
            {
                var res = dbConnection.Query("SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit",
                    param: new { idGr = 10, limit = 50 })
                    .ToList();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds / c);

            sw = Stopwatch.StartNew();
            for (int i = 0; i < c; i++)
            {
                var dslCtxt = new SQLiteDSLContext();
                var ts = dslCtxt
                    .Select(Tbl_Cards.Id(), Tbl_Cards.Name(), Tbl_Cards.Form().As("test"))
                    .From<Tbl_Cards>()
                    .Where(Tbl_Cards.Id().Greater(10))
                    .OrderBy(Tbl_Cards.Id())
                    .Limit(50)
                    .QueryBuilder
                    .BuildPreparedStatement();

                var res = dbConnection.Query(ts.Statement,
                    param: ts.Parameters)
                    .ToList();
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds / c);

            //var sql = new Table1()
            //.Select(new Table1.Column1().As("hello"), new Table1.Column1())
            //.ToSqlString();
        }

        [TestMethod]
        public void StmtClassNameImplementTest()
        {
            var qb = new SQLiteDSLContext().QueryBuilder;
            qb.AddStatment(new FromStatement());
            qb.Build();
        }
    }
}