# TypeSafeSql
A library for writing type safe SQL statements in code - based on DSL basics.

## Example
Simple query using TypesafeSql and Dapper:
```C#
// Build query with TypesafeSql
var dslCtxt = new SQLiteDSLContext();
var ts = dslCtxt
    .Select(Tbl_Cards.Id(), Tbl_Cards.Name(), Tbl_Cards.Form().As("test"))
    .From<Tbl_Cards>()
    .Where(Tbl_Cards.Id().Greater(10))
    .OrderBy(Tbl_Cards.Id())
    .Limit(50)
    .QueryBuilder
    .BuildPreparedStatement();

// Use result as input for Dapper query
var res = dbConnection.Query(ts.Statement, param: ts.Parameters)
    .ToList();
```

Joins and Where statements:
```C#
var stmt = dslCtxt
    .Select()
    .All()
    .From<TblCards>()
    .InnerJoin<TblCards, TblPacks>()
    .On(TblCards.Pack_id(), TblPacks.Id())
    .Where(TblCards.Attribute().Equal("s")
        .And(TblCards.Form().Equal("c"))
        .Group()
        .And(TblCards.Id().Equal(1)
        .And(TblCards.Id().Equal(2))))
    .Limit(20)
    .Offset(5)
    .QueryBuilder
    .BuildPreparedStatement();
```

##Why?
Don't limit yourself to abstracted libraries / frameworks and utilize the potential databases provide.
Enjoy writing SQL - with armor.

**"Why not use a ORM?"**
I used ORMs in multiple projects and have not had good experiences using them.
Most of them forced me to do a "code first" approach which never worked for me as I design my database schemes first.
Besides there were issues with errors during setup I spent hours fixing and figuering out cryptic error messages.

When I had adjusted my code to the needs of the ORM and fixed error messages I got problems writing my statements.
Easy ones are easy but once you get a bit more complex you basically have to write SQL again.

In the end hand-written SQL queries are required again.

So let's make sure that we get more safety when writing SQL queries and utilize the power of typed programming languages like C#.


##How does it work?
For the query itself to the database you need to use an provider - this library only helps you by creating SQL query strings.
Recommendation for querying data: https://github.com/DapperLib/Dapper

1. Use binary (.exe) of TypesafeSql.Generate to create classes from database
2. Include TypesafeSql library in your project

###Prerequisite
TypesafeSql builds upon 
- an existing database scheme
and makes the output available for databases providers to query from the database.


## Performance impact
Function calls and string builder bring overhead to the table. 
If you are running queries in a hot path - check if it has a major impact on performance.
Shouldn't because of JIT opitmisations but check either way.

## Benchmark
Benchmarking a simple SQL query which benefits TypesafeSql
```SQL
SELECT Id, Name, Form as 'test' FROM cards WHERE id > @idGr ORDER BY Id LIMIT @limit
```
and translated to code with TypesafeSql
```C#
dslCtxt
.Select(TblCards.Id(), TblCards.Name(), TblCards.Form().As("test"))
.From<TblCards>()
.Where(TblCards.Id().Greater(10))
.OrderBy(TblCards.Id())
.Limit(50)
.QueryBuilder
.BuildPreparedStatement();
```
Running those queries against a SQLite database in combination with Dapper returns following results
|      Method |     Mean |   Error |  StdDev | Ratio | RatioSD |
|------------ |---------:|--------:|--------:|------:|--------:|
|   DapperRaw | 179.4 us | 1.48 us | 1.38 us |  1.00 |    0.00 |
| TypeSafeSql | 191.4 us | 2.28 us | 2.02 us |  1.07 |    0.02 |

TypesafeSql adds about 7% overhead.

What to check out next:
- Source generators to transform queries during compilation to SQL strings
  This approach would not cause any performance impact at runtime at all - type safety for free.

##What kind of potential errors can be avoided?
A very good answer on Stackoverflow: https://stackoverflow.com/questions/22860167/what-exactly-does-type-safe-queries-means

##What type of errors are still possible?


## Project setup
