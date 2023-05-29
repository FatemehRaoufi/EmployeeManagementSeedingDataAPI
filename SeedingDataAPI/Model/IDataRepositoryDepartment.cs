using System.Collections.Generic;

namespace SeedingDataAPI.Model
{
    public interface IDataRepositoryDepartment
    {
        List<Department> AddDepartment(Department Department);
        List<Department> GetDepartments();
        Department PutDepartment(Department Department);
        Department GetDepartmentById(int id);
    }
}
