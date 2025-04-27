using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Position { get; set; } = null!;

        public virtual ICollection<RepairOrderEmployee> RepairOrderEmployees { get; set; } 
            = new HashSet<RepairOrderEmployee>();
    }
}
