# Object-Relational Mapping (ORM) Comparison

A REST API and class libraries that provide a comparative example for Entity Framework (both code-first and data-first), Dapper, and ADO.Net itself.

## Projects

- ormc.Api : A REST API that serves as the interface for each of the examples.
- ormc.Ado : An example of a bare-bones ADO.NET implementation.
- ormc.Dapper : An example of a Dapper implementation.
- ormc.DataFirst : An example of an Entity Framework Core data-first implementation.
- ormc.CodeFirst : An example of an Entity Framework Core code-first implementation.

## Setup

To deploy the database scripts, first create a database in a SQL Server instance, then execute the following from the ormc.Sql folder:

`./deploy.ps1 {instance} {database}`

For example, to deploy it on a database called **ormc-local** on the default local instance:

`./deploy.ps1 localhost ormc-local`

There is also a SeedData.sql file that can be executed manually to populate the database with data.

Most of the ormc.DataFirst library was generated from the Entity Framework Core CLI tools. To install these tools:

`dotnet tool install --global dotnet-ef`

And to scaffold the DataFirst project:

`dotnet ef dbcontext scaffold "Server=localhost;Database=ormc-local;Integrated Security=SSPI;Application Name=ormc;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context Context --data-annotations --no-pluralize`

Help for these tools is at https://learn.microsoft.com/en-us/ef/core/cli/dotnet.

# Interface

https://localhost:7046/swagger/index.html

# Migrations

In order to illustrate how Code First EF implementations employ Migrations, the following commands were executed:

`dotnet ef migrations add Initial --project ormc.CodeFirst --startup-project ormc.Api --context ormc.CodeFirst.DataAccess.Context`
`dotnet ef migrations add DriverFirstName --project ormc.CodeFirst --startup-project ormc.Api --context ormc.CodeFirst.DataAccess.Context`
