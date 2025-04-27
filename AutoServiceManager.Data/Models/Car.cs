using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Castle.Core.Logging;

namespace AutoServiceManager.Data.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public string RegNumber { get; set; } = null!;

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        //Every car have one customer
        public Guid CustomerId { get; set; }

        public Customer? Customer { get; set; }


        //One car can have many repair orders
        public virtual ICollection<RepairOrder> RepairOrders { get; set; } 
            = new HashSet<RepairOrder>();
    }
}