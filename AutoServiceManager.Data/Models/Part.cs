using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Part
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }


        public virtual ICollection<RepairOrderPart> RepairOrderParts { get; set; } 
            = new HashSet<RepairOrderPart>();
    }
}
