# 2025-1PDS8-10

# Commandos git 
- git fetch
- git pull

- git add *
- git commit -am "Descripcion"
- git push

# Commandos dotnet 
- dotnet run
- dotnet restore
- dotnet add package NAME --version NUMBER
- dotnet remove package NAME

- dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 7.0.20
- dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.20
- dotnet add package System.Data.SqlClient --version 4.8.6
- dotnet add package Newtonsoft.Json --version 13.0.3
- dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 6.0.33
- dotnet add package Swashbuckle.AspNetCore --version 6.2.3
- dotnet add package Moq --version 4.20.71

- dotnet remove package System.Data.SqlClient

- Remover todo lo de github
- Control Panel\User Accounts\Credential Manager

# Proyectos
- ASP.NET Core Web API
	- No usar: configurar Https
	- Use OpenAPI # Swagger

	- Secrets: Click derecho en el proyecto->Manage User Secret
- ASP.NET Core Web App (Razor Pages)
	- No usar: configurar Https
- Class Library
- MSTest Test Project

# Migration
- View -> Other windows -> Package Manager Console
- Seleccionar el proyecto que contenga la conexion y ejecutar
- PM> Add-Migration migration1

# Publicar pagina local
- Folder | Carpeta
- bin\Release\publish\