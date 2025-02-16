using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using Microsoft.VisualBasic;
using System.Reflection;
using C43_G05_EF01.Contexts;

namespace C43_G05_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // What is Entity Framework Core(EF Core) ?

            // Entity Framework Core is an open - source, cross - platform Object
            // - Relational Mapper(ORM) developed by Microsoft.It simplifies database
            // interactions by allowing developers to work with relational data using
            // .NET objects, eliminating the need for most low-level SQL queries.EF Core
            // supports multiple database providers(e.g., SQL Server, SQLite, PostgreSQL, MySQL)
            // and is part of the.NET ecosystem.


            // Key Features

            // Cross - Platform: Runs on Windows, Linux, and macOS.

            // LINQ Support: Query data using Language-Integrated Query(LINQ) in C#.

            // Code - First & Database - First Workflows:

            // Code - First: Define models in code and generate the database schema.

            // Database - First: Scaffold models from an existing database.

            // Migrations: Manage incremental database schema changes.

            // Change Tracking: Automatically tracks changes to entities for updates.

            // Database Providers: Extensible to work with SQL and NoSQL databases.

            // Performance Optimizations: Async operations, batching, and raw SQL execution.


            // How EF Core Works

            // EF Core bridges the gap between object-oriented code and relational databases. It translates LINQ queries to SQL, executes commands, and maps results to .NET objects. Key processes include:

            // Modeling: Define entities(C# classes) and relationships.

            // Querying: Use LINQ to retrieve/ manipulate data.

            // Change Tracking: Track entity changes(add, update, delete).

            // Persistence: Save changes to the database via SaveChanges().


            // Workflow

            //Define Models: Create entity classes and a DbContext.

            // Configure Database Provider: Specify connection strings and database type.

            // Create Migrations: Generate SQL schema from models.

            // Query and Manipulate Data: Use LINQ for CRUD operations.

            // Save Changes: Persist changes with SaveChanges().

            // +++++++++++++++++++++++++++++++++++++++++++++++

            AppDbContext context = new AppDbContext();

        }
    }
}
