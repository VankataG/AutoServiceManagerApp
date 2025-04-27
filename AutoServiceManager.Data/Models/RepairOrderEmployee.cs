using System.ComponentModel.DataAnnotations.Schema;

namespace AutoServiceManager.Data.Models
{
    public class RepairOrderEmployee
    {
        public Guid RepairOrderId { get; set; }
        public virtual RepairOrder RepairOrder { get; set; } = null!;


        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } = null!;

    }
}