using System.Collections.Generic;
using System.Linq;

namespace SeedingDataAPI.Model
{
    public class DataSeeder
    {
        private readonly EmployeeDbContext employeeDbContext;

        public DataSeeder(EmployeeDbContext employeeDbContext)
        {
            this.employeeDbContext = employeeDbContext;
        }

        public void Seed()
        {
            if (!employeeDbContext.Employee.Any())
            {
                if (!employeeDbContext.Department.Any())
                {
                    var departments = new List<Department>()
                {
                        new Department {  Name = "HR" },
                        new Department {  Name = "Admin" },
                        new Department {  Name = "Development" }
                };

                    employeeDbContext.Department.AddRange(departments);
                    employeeDbContext.SaveChanges();
                }
                //.....................
                if (!employeeDbContext.Project.Any())
                {
                    var projects = new List<Project>()
                {
                        new Project {  Name = "Cricket" },
                        new Project {  Name = "Politics" },
                        new Project {  Name = "Boxing" },
                        new Project {  Name = "Racing" },
                        new Project {  Name = "Football" },
                        new Project {  Name = "Tennis" }
                };

                    employeeDbContext.Project.AddRange(projects);
                    employeeDbContext.SaveChanges();
                }
                //.....................
                var employees = new List<Employee>()
                {
                     new Employee {  Name = "Angela Merkel", DepartmentID = 1 },
                     new Employee {  Name = "Rahul Dravid", DepartmentID =2 },
                     new Employee {  Name = "Cristiano Ronaldo", DepartmentID = 2 },
                     new Employee {  Name = "Virat Kohli", DepartmentID = 2 },
                     new Employee {  Name = "Muhammad Ali", DepartmentID = 3 },
                     new Employee {  Name = "Michael Schumacher", DepartmentID = 3 },
                     new Employee {  Name = "Lionel Messi", DepartmentID = 2 },
                     new Employee {  Name = "Rafael Nadal", DepartmentID = 3 }

                };

                employeeDbContext.Employee.AddRange(employees);
                employeeDbContext.SaveChanges();
            }

            //.....................
           
            if (!employeeDbContext.EmployeeAddress.Any())
            {
                var employeeAddress = new List<EmployeeAddress>()
                {
                       new EmployeeAddress { EmployeeId = 1, Address = "Berlin, Germany" },
                       new EmployeeAddress { EmployeeId = 2, Address = "Bangalore, India" },
                       new EmployeeAddress { EmployeeId = 3, Address = "Funchal, Madeira" },
                       new EmployeeAddress { EmployeeId = 4, Address = "NewDelhi, India" },
                       new EmployeeAddress { EmployeeId = 5, Address = "Kentuki, USA" },
                       new EmployeeAddress { EmployeeId = 6, Address = "Hurth, Germany" },
                       new EmployeeAddress { EmployeeId = 7, Address = "Rosario, Argentina" },
                       new EmployeeAddress { EmployeeId = 8, Address = "Manacor, Spain" }
                };

                employeeDbContext.EmployeeAddress.AddRange(employeeAddress);
                employeeDbContext.SaveChanges();
            }
            //...........................
            if (!employeeDbContext.EmployeesInProject.Any())
            {
                var employeesInProject = new List<EmployeesInProject>()
                {
                        new EmployeesInProject { EmployeeId = 1, ProjectId = 2 },
                        new EmployeesInProject { EmployeeId = 1, ProjectId = 4 },
                        new EmployeesInProject { EmployeeId = 2, ProjectId = 2 },
                        new EmployeesInProject { EmployeeId = 2, ProjectId = 3 },
                        new EmployeesInProject { EmployeeId = 3, ProjectId = 3 },
                        new EmployeesInProject { EmployeeId = 3, ProjectId = 2 },
                        new EmployeesInProject { EmployeeId = 4, ProjectId = 1 },
                        new EmployeesInProject { EmployeeId = 4, ProjectId = 3 },
                        new EmployeesInProject { EmployeeId = 5, ProjectId = 3 },
                        new EmployeesInProject { EmployeeId = 5, ProjectId = 2 },
                        new EmployeesInProject { EmployeeId = 6, ProjectId = 4 },
                        new EmployeesInProject { EmployeeId = 6, ProjectId = 2 },
                        new EmployeesInProject { EmployeeId = 7, ProjectId = 5 },
                        new EmployeesInProject { EmployeeId = 7, ProjectId = 1 },
                        new EmployeesInProject { EmployeeId = 8, ProjectId = 6 },
                        new EmployeesInProject { EmployeeId = 8, ProjectId = 5 }
                };

                employeeDbContext.EmployeesInProject.AddRange(employeesInProject);
                employeeDbContext.SaveChanges();
            }
        }
    }
}
