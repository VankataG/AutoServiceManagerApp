using System.ComponentModel.DataAnnotations;

namespace AutoServiceManager.Data.Models
{
    public class Part
    {
        [Key]
        public Guid Id { get; set; }

        [Required] 
        [MaxLength(200)] 
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }


        public virtual ICollection<RepairOrderPart> RepairOrderParts { get; set; } 
            = new HashSet<RepairOrderPart>();
    }
}
