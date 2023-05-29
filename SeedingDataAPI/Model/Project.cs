using System.ComponentModel.DataAnnotations;

namespace SeedingDataAPI.Model
{
    public class Project
    {

        public int ProjectId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmployeesInProject> Employees { get; set; }
    }
}
