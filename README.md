# Course Management API

## Technologies Used

- ASP.NET Core Web API: Backend framework for building RESTful APIs
- Entity Framework Core: ORM for database operations
- SQL Server: Database management system
- JWT Authentication: Secure user authentication
- Swagger: API documentation and testing tool

## How to Run

1. Run migrations:
   dotnet ef database update

2. Run project:
   dotnet run

3. Open Swagger:
   https://localhost:xxxx/swagger

## Authentication

Use:
- Username: admin
- Password: 123

## Why HTTP-only Cookies?

HTTP-only cookies are used because they prevent JavaScript access, protecting authentication tokens from XSS attacks and improving security.