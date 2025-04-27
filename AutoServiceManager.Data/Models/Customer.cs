using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(200)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string Number { get; set; } = null!;

        public string? Email { get; set; }

        public string? Address { get; set; }

        //One Customer can have many cars
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }


}
