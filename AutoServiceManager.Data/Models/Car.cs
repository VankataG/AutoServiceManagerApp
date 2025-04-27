using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Castle.Core.Logging;

namespace AutoServiceManager.Data.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegNumber { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Make { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }


        //Every car have one customer
        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }

        public Customer? Customer { get; set; }

        //One car can have many repair orders
        public virtual ICollection<RepairOrder> RepairOrders { get; set; } 
            = new HashSet<RepairOrder>();
    }
}