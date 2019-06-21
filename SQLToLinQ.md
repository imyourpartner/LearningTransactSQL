

# Convirtiendo sentencias Transact SQL  a LinQ

## Microsoft EntityFrameworkCore

Entity Framework Core es una versión ligera y extensible de la popular tecnología de acceso a datos de Entity Framework. 

Tipos de uso común: 
Microsoft.EntityFrameworkCore.DbContext 
Microsoft.EntityFrameworkCore.DbSet   

Comandos de instalación:

NuGet

```
Install-Package Microsoft.EntityFrameworkCore -Version 2.2.4
```

NET CLI

```
dotnet add package Microsoft.EntityFrameworkCore --version 2.2.4
```

## Microsoft.EntityFrameworkCore.SqlServer

Proveedor de base de datos de Microsoft SQL Server para Entity Framework Core. 

Comandos de instalación:

NuGet

```
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.2.4
```

NET CLI

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 2.2.4
```

## Microsoft.EntityFrameworkCore.Tools

Comandos de librería:

- Add-Migration
- Drop-Database
- Get-DbContext
- Scaffold-DbContext
- Script-Migrations
- Update-Database

Comandos de instalación:

NuGet

```
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 2.2.4
```

NET CLI

```
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 2.2.4
```

- Scaffold-DbContext: Permite Crear el modelo de EF en función de la base de datos existente

  

```
Scaffold-DbContext 
"Server=MiServidor.com;
Database=NombreDeLaBaseDeDatos;
User=UsuarioDeLaBaseDedatos;
Password=ContrasenaDeLaBaseDeDatos;"
Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

LocalHost

```
Scaffold-DbContext 
"Server=(localdb)\mssqllocaldb;
Database=DatabaseName;
Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```

Cloud

```
Scaffold-DbContext 
"Server=sql5041.site4now.net;
Database=DB_A4919A_Testing;
User=DB_A4919A_Testing_admin;Password=DB_A4919A_;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir db\AdventureWorks2017\Models\
```

scascasc







# 

Enables these commonly used commands:
