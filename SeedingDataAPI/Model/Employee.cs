using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeedingDataAPI.Model
{
    public class Employee
    {
             
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        
        public virtual Department Department { get; set; }

        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual ICollection<EmployeesInProject> Projects { get; set; }
    }
}
