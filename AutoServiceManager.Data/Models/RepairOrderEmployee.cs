using System.ComponentModel.DataAnnotations.Schema;

namespace AutoServiceManager.Data.Models
{
    public class RepairOrderEmployee
    {
        [ForeignKey(nameof(RepairOrder))]
        public Guid RepairOrderId { get; set; }
        public virtual RepairOrder RepairOrder { get; set; } = null!;


        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } = null!;

    }
}