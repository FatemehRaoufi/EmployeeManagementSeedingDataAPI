using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeedingDataAPI.Model
{
    public class EmployeesInProject
    {
        public int EmployeesInProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }
}
