## .Net Core + Entity Framework + SQL Server

### Install package manager console

```js
dotnet tool install --global dotnet-ef
```

### Migrations

```js
dotnet ef migrations add CreateInitial
```

### Create DB and tables

```js
dotnet ef database update
```

### Install package dependencies

```js
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.AspNetCore.Cors
Microsoft.EntityFrameworkCore.Design
```
