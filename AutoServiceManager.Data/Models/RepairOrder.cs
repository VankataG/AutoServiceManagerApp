using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoServiceManager.Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace AutoServiceManager.Data.Models
{
    public class RepairOrder
    {
        public Guid Id { get; set; }

        public Guid CarId { get; set; }

        public virtual Car Car { get; set; } = null!;


        [Comment("Date of accepting the car for repair")]
        public DateOnly Date { get; set; }


        [Comment("Diagnose/Problem of the car, that have to be fixed")]
        public string Problem { get; set; } = null!;

            
        [Comment("Status of the repair")]
        public Status Status { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<RepairOrderPart> RepairOrderParts { get; set; } 
            = new HashSet<RepairOrderPart>();
        public virtual ICollection<RepairOrderEmployee> RepairOrderEmployees { get; set; } 
            = new HashSet<RepairOrderEmployee>();
    }
}
