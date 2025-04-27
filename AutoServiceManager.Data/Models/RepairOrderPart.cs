using System.ComponentModel.DataAnnotations.Schema;

namespace AutoServiceManager.Data.Models
{
    public class RepairOrderPart
    {
        public Guid RepairOrderId { get; set; }
        public virtual RepairOrder RepairOrder { get; set; } = null!;


        public Guid PartId { get; set; }
        public virtual Part Part { get; set; } = null!;
    }
}