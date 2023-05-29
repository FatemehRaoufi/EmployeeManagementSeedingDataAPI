using System.Collections.Generic;

namespace SeedingDataAPI.Model
{
    public interface IDataRepositoryEmployee
    {
        List<Employee> AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        Employee PutEmployee(Employee employee);
        Employee GetEmployeeById(string id);
    }
}
