# Hackathon Fundación Esplai: Login & Registro

[![CodeFactor](https://www.codefactor.io/repository/github/ivan-moreno/hackathon-login-app/badge/master)](https://www.codefactor.io/repository/github/ivan-moreno/hackathon-login-app/overview/master)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ivan-moreno_hackathon-login-app&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=ivan-moreno_hackathon-login-app)


Aplicación [ASP.NET Core](https://dotnet.microsoft.com/en-us/learn/aspnet/what-is-aspnet-core) MVC con [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core) que simula el registro e inicio de sesión de usuarios en una web.

## Instalación

1. Clonar o descargar un .ZIP con el código de este repositorio.
2. Abrir el proyecto con [Visual Studio](https://visualstudio.microsoft.com) o un IDE similar.
3. Añadir un servicio **SQL Server** con los siguientes campos:
    - Connection String Name: `localDatabase`
    - Connection String Value: `Server=(localdb)\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true`
4. En la ventana **Package Manager Console**, introducir el siguiente comando: `update-database`
5. Ejecutar.

En caso de problemas de dependencias, se deben instalar los siguientes paquetes NuGet en el proyecto:
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/7.0.5?_src=template)
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/7.0.5?_src=template)
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/7.0.5?_src=template)
- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/7.0.6?_src=template)

## Contacto

- [Iván Moreno Pérez en **LinkedIn**](https://www.linkedin.com/in/iv%C3%A1n-moreno-p%C3%A9rez)

## Licencia

<a rel="license" href="http://creativecommons.org/licenses/by/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by/4.0/">Creative Commons Attribution 4.0 International License</a>.
