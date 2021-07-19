# Sales Web MVC
A basic CRUD web page for register sellers and departments made using ASP.NET Core MVC on Linux connected to SQL Server.

# Used tools:
- Rider IDE;
- Docker (to host SQL Server);
- DBeaver (to model the database and create the queries);
- .Net Core 5.0.3
- .Net Core Entity Framework 5.0.8

# NuGet packages used:
- Microsoft.EntityFrameworkCore (5.0.8)
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.8)
- Microsoft.EntityFrameworkCore.Design (5.0.8)
- Microsoft.EntityFrameworkCore.SqlServer (5.0.8)
- Microsoft.Data.SqlClient (3.0.0)
- Microsoft.EntityFrameworkCore.Relational (5.0.8)
- Microsoft.EntityFrameworkCore.Tools (5.0.8)
- Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2)

# How to use?
- First, you must have SQL Server installed on your machine (natively or via Docker) and .Net Core 5.0 or greater;
- Clone the repository;
- On PowerShell or Bash, run the following command to download the Entity Framework `dotnet tool install --global dotnet-ef`;
- Again, on PowerSehll or Bash, go to the project file (*/Snacks_MVC_SqlServer/SnackApp/*) and update the database using EF command: `dotnet ef database update`;
- Any doubts, look at the oficial Microsoft documentation: https://docs.microsoft.com/en-us/ef/core/cli/dotnet and https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- Inside the file "appsettings.json", change the connection string to your SQL Server instance according to your needs.

- TODO: change the image to the new connection string name (same print otherwise)
![Screenshot_20210713_142335](https://user-images.githubusercontent.com/73988556/125498401-4baccacd-be49-420f-be61-e05f50156844.png)


# Page illustration

TBA
