# EmployeeManagementSeedingDataAPI

This is an ASP.NET Core Web API project for managing employee data and departments. The API includes CRUD operations for employees, departments, and employee addresses. It also demonstrates how to seed data into a database using Entity Framework Core.

## Project Structure

```
EmployeeManagementSeedingDataAPI/
│
├── Controllers/                          
│   ├── EmployeeController.cs             # Manages employee data and related operations
│   └── DepartmentController.cs           # Manages department data and related operations
│
├── Models/                               
│   ├── Employee.cs                       # Employee model definition
│   ├── Department.cs                     # Department model definition
│   ├── EmployeeAddress.cs                # Employee address model definition
│   ├── Project.cs                        # Project model definition
│   ├── EmployeesInProject.cs             # Many-to-many relationship between employees and projects
│   ├── IDataRepositoryEmployee.cs        # Interface for employee data operations
│   ├── IDataRepositoryDepartment.cs      # Interface for department data operations
│   ├── DataRepositoryEmployee.cs         # Implementation of employee data operations
│   ├── DataRepositoryDepartment.cs       # Implementation of department data operations
│   └── DataSeeder.cs                     # Seeder class for inserting data into the database
│
├── Data/                                 
│   └── EmployeeDbContext.cs              # DB context for interacting with SQL Server
│
├── appsettings.json                      # Application settings and database connection strings
├── Program.cs                            # Configures and runs the web application
├── Startup.cs                            # Configures services, middleware, etc.
└── README.md                            # You're reading it now

```

## Features

- **Employee Management:** CRUD operations for employee data.
- **Department Management:** CRUD operations for department data.
- **Seeding Data:** Automatically inserts initial data (employees, departments, and projects) if the database is empty.
- **Many-to-Many Relationship:** Between employees and projects.

## Technologies Used

- **.NET 7.0**
- **Entity Framework Core 7.0.2**: For database interactions and data seeding.
- **SQL Server** : Used for storing employee, department, and project data.
- **Swagger / OpenAPI** (via Swashbuckle 6.5.0): For API documentation and testing endpoints.
- **ASP.NET Core Web API**: For creating RESTful API services.


## Setup

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/EmployeeManagementSeedingDataAPI.git
   ```

- **Data Seeding**:
  - Automatically seeds initial data (employees, departments, projects) if the database is empty.

- **Database**:
  - Uses SQL Server for storing employee, department, address, and project data.

- **API Documentation**:
  - API is documented with Swagger for easy exploration and testing.

## Prerequisites

To run this project locally, you'll need:

- .NET 7.0 or later installed.
- SQL Server or a compatible database.
- Visual Studio or a code editor like VS Code.

## Getting Started

Follow these steps to get the project up and running:

 1. Clone the Repository

Clone the project to your local machine:

```
git clone <your-repository-url>
```

2. Install Dependencies
Make sure to restore the necessary NuGet packages for the project. Run the following command in the terminal:

3. Configure Database Connection
In the appsettings.json file, set up your database connection string. Example:

```
"ConnectionStrings": {
  "AppDb": "Data Source=.;Initial Catalog=EmployeeDb;Integrated Security=True"
}
```

Ensure that the database is accessible, or use SQL Server Express if you prefer local development.

4. Apply Migrations
Run the following commands to create the necessary database tables:

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

5. Seed Data
The data will be seeded automatically if the database is empty. Alternatively, you can manually seed the data by running the following command in the terminal:

```
dotnet run seeddata
```

6. Run the Application
To run the application, use the following command:

```
dotnet run
```
The API will be available at
```
http://localhost:5000.
```
7. Access the API Documentation
Once the application is running, you can view the API documentation at
```
 http://localhost:5000/swagger.
```
Swagger will provide an interactive interface to test the API endpoints.

Endpoints
Here are the available API endpoints:

```
GET /employees – Retrieves a list of all employees.
GET /employee/{id} – Retrieves an employee by ID.
POST /employee – Adds a new employee.
PUT /employee/{id} – Updates an existing employee.
GET /departments – Retrieves a list of all departments.
GET /department/{id} – Retrieves a department by ID.
POST /department – Adds a new department.
PUT /department/{id} – Updates an existing department.
```
