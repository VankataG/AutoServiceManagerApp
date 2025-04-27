using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Number { get; set; } = null!;

        public string? Email { get; set; }

        public string? Address { get; set; }

        //One Customer can have many cars
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }


}
