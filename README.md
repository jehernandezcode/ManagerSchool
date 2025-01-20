# ManagerSchool

## Características

Para este proyecto se contemplo los siguientes concepto:

- .NET 8
- C#
- XUnit
- Swagger y sus anotaciones
- Global Filter Exception
- Validaciones y atributos de validacion DTOs
- Flujo JWT (autenticacion y authorizacion por bearer token)
- Inyeccion de dependencias
- SQl Server
- DDD


## Requisitos previos

- .NET 8 SDK
- IDE de su preferencia

## Instalación

1. Clona el repositorio:

   https://github.com/jehernandezcode/ManagerSchool.git

2. Navega al directorio del proyecto - SchoolManager

3. Restaura las dependencias:

dotnet restore
dotnet build

4. Ejecutar el proyecto o desde su editor de confianza

dotnet run

## Ejecucion de Test Unitarios

dotnet test


## appsettings.Development

{
    "ConnectionStrings": {
        "Database": "Server=localhost;Database=su__db;User Id=sa;Password=password;Encrypt=false"
    },
    "Jwt": {
        "Issuer": "ManagerSchool",
        "Audience": "jhonnHernandez",
        "SecretKey": "your-very-secret-keyjsdhfkjsdhfjksdhfjklsdfjklhsdjklfhjklsdhfjklsdhjklfhsdklufhsdjklfh",
        "ExpirationMinutes": 60.0
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft.AspNetCore": "Warning"
        }
    }
}


## Uso Local

1. Ejecutar el proyecto

dotnet run --project api-number-at-letters/api-number-at-letters.csproj

2. La Api estara disponible en: http://localhost:5071

3. Accede a la documentacion de Swagger en: http://localhost:5071/swagger/index.html

#Migraciones
Abriendo la consola del administador de paquetes, ingrese el codigo

- database-update

## Coleccion Postman

Este recurso se encuentra en la raiz del proyecto.
