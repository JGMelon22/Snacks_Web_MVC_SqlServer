# Sales Web MVC
A basic CRUD web page which simluates a Snack Store experience made using ASP.NET Core MVC on Linux connected to SQL Server.

# Used tools:
- Rider IDE;
- Docker (to host SQL Server);
- DBeaver (to model the database and create the queries);
- .Net Core 5.0.3;
- .Net Core Entity Framework 5.0.8.

# NuGet packages used:
- Microsoft.EntityFrameworkCore (5.0.8);
- Microsoft.AspNetCore.Identity.EntityFrameworkCore (5.0.8);
- Microsoft.EntityFrameworkCore.Design (5.0.8);
- Microsoft.EntityFrameworkCore.SqlServer (5.0.8);
- Microsoft.Data.SqlClient (3.0.0);
- Microsoft.EntityFrameworkCore.Relational (5.0.8);
- Microsoft.EntityFrameworkCore.Tools (5.0.8);
- Microsoft.VisualStudio.Web.CodeGeneration.Design (5.0.2);
- ReflectionIT.Mvc.Paging (5.1.1).

# How to use?
- First, you must have SQL Server installed on your machine (natively or via Docker) and .Net Core 5.0 or greater;
- Clone the repository;
- On PowerShell or Bash, run the following command to download the Entity Framework `dotnet tool install --global dotnet-ef`;
- Again, on PowerSehll or Bash, go to the project file (*/Snacks_MVC_SqlServer/SnackApp/*) and update the database using EF command: `dotnet ef database update`;
- Any doubts, look at the oficial Microsoft documentation: https://docs.microsoft.com/en-us/ef/core/cli/dotnet and https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- Inside the file "appsettings.json", change the connection string to your SQL Server instance according to your needs.

![Screenshot_20210719_200323](https://user-images.githubusercontent.com/73988556/126238586-0de79583-6c9b-46ac-9adf-b5af345b979e.png)

# Page illustration
![Screenshot_20210723_145708](https://user-images.githubusercontent.com/73988556/126823018-4d66c321-7543-4d90-a3ef-d16ffa396a5a.png)

![Screenshot_20210723_145714](https://user-images.githubusercontent.com/73988556/126823026-b77d96ad-efda-4fc5-93ea-39ce7523a748.png)

![Screenshot_20210723_145732](https://user-images.githubusercontent.com/73988556/126823039-b6a470c8-7437-4c3d-a679-c59cff326666.png)

![Screenshot_20210723_150027](https://user-images.githubusercontent.com/73988556/126823065-accbfc5f-51ca-4911-9a8b-72484878686e.png)

![Screenshot_20210723_150035](https://user-images.githubusercontent.com/73988556/126823075-e587b2dd-f1c7-4382-b214-4ad118433b44.png)

![Screenshot_20210723_150043](https://user-images.githubusercontent.com/73988556/126823093-66a7fc8c-5eb7-4fb7-acab-9748aa93d0a1.png)

![Screenshot_20210723_150050](https://user-images.githubusercontent.com/73988556/126823099-7ebf1deb-f1c0-40cf-a5c3-4010695af430.png)
