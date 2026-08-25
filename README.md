# Student Management API

A RESTful Web API for managing student records using C#, ASP.NET Core, Entity Framework Core, and SQL Server.

## Technologies Used

- C#
- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- REST API
- Git & GitHub

## Features

- Add new student records
- View all students
- Update student details
- Delete student records
- SQL Server database integration
- Entity Framework Core migrations
- RESTful API endpoints

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/students` | Get all students |
| POST | `/api/students` | Add a new student |
| PUT | `/api/students/{id}` | Update a student |
| DELETE | `/api/students/{id}` | Delete a student |

## Database

The project uses **SQL Server** for storing student records and **Entity Framework Core** for database operations and migrations.

Database:
- `StudentManagementDB`

Table:
- `Students`

## How to Run

1. Clone the repository.
2. Open the project in VS Code.
3. Update the SQL Server connection string in `appsettings.json`.
4. Run database migrations:

```bash
dotnet ef database update

```

5. Start the API:

```bash
dotnet run
```

6. Test the API using the `.http` file or REST Client extension.

## Author

**Akshay Boinwad**

GitHub: [akshay-boinwad](https://github.com/akshay-boinwad)