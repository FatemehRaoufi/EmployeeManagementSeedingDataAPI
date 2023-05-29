using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeedingDataAPI.Model
{
    public class EmployeeAddress
    {

        [Key, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
