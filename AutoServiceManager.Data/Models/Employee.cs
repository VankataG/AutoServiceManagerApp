using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Position { get; set; } = null!;

        public virtual ICollection<RepairOrderEmployee> RepairOrderEmployees { get; set; } 
            = new HashSet<RepairOrderEmployee>();
    }
}
