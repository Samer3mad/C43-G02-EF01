using System.Reflection.Emit;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is ORM and EFCore
            ///Object Relational Mapping (ORM) is a technique used in creating a "bridge" between 
            ///object-oriented programs and, in most cases, relational databases.

            ///When interacting with a database using OOP languages, you'll have to perform different operations 
            ///like creating, reading, updating, and deleting (CRUD) data from a database. 
            ///By design, you use SQL for performing these operations in relational databases.*/

            ///An ORM tool is software designed to help OOP developers interact with relational databases.
            ///So instead of creating your own ORM software from scratch, you can make use of these tools.
            #endregion

            #region Ado.Net VS EF Core VS Dapper

            #region Ado.Net
            //In the Past, we used to work with databases in .NET  by using ADO.NET,
            //which was the primary solution before the emergence of Entity Framework (EF).

            //ADO.NET is a database access technology that is part of the .NET Framework.
            //It provides a set of classes and interfaces that allow .NET applications to interact with databases.
            //ADO.NET has been around for a long time and is widely used in .NET applications.
            //ADO.NET is a low-level tool, which means that it provides fine-grained control over database operations.

            //Any false syntax or erxtra letter may case a big problem to server.

            //You need to try code in SQL Server before use it in Ado.Net on Visual Studio Code to avoiding any error.
            #endregion

            #region Entity Framework Core
            // (EF Core) is a high-level ORM (Object-Relational Mapping) tool that allows .NET applications to interact with databases.
            // It provides a set of classes and APIs that abstract the database operations, making it easier for developers to work with databases.
            // EF Core is built on top of ADO.NET, which means it uses ADO.NET internally to interact with databases.

            //Any error or syntax error is very obvious

            //supports several database providers, including SQL Server, MySQL, SQLite, PostgreSQL and LINQ.
            #endregion

            #region Dapper
            //Dapper is a micro ORM that was developed by the StackOverflow team.
            //It provides a lightweight and fast way to work with databases.
            //Dapper is built on top of ADO.NET and provides a simple API for database operations.
            //Dapper is designed to be fast and efficient, which means that it doesn't have some of the features provided by EF Core.

            //Dapper is ideal for scenarios where performance is critical and developers want fine-grained control over the database operations.

            //Dapper is also easy to learn and use, providing a small set of APIs covering most of the database operations.
            #endregion

            #region Conclusion

            /// Performance:-
            /// Dapper is faster than EF Core and Ado.Net.
            /// Ado.Net is faster than EF Core.
            /// Dapper > Ado.Net > EF Core

            /// Ease of use:-
            /// EF Core is clearly winner
            /// Dapper is also easy to use but requires developers to write SQL queries.

            /// Features:-
            /// EF Core clearly winner because it have a lot of features 
            /// such as automatic schema migration, query translation, and change tracking.
            /// Dapper doesn't provide all of these features, which means that developers have to implement them themselves.
            /// ADO.NET is a low-level tool and doesn't provide as many features as EF Core.

            /// Flexibility:-
            /// Dapper is the most flexible tool among the three because it allows developers to write SQL queries and map the results to any class or structure.
            /// EF Core is less flexible than Dapper because it requires developers to define classes that map to database tables.
            /// ADO.NET is also less flexible than Dapper because it requires developers to write more code to map the results to classes or structures.

            /// Which Tool Should We Use?
            /// If you need a lightweight and fast tool for database operations, Dapper is a good choice.
            /// If you need a tool that provides a high - level API and many features, EF Core is a good choice.
            /// If you need fine - grained control over database operations, ADO.NET is a good choice.

            #endregion
            
            #endregion
        }
    }
}
