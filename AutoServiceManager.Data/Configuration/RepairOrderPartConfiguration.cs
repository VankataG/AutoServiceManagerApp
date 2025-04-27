using AutoServiceManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoServiceManager.Data.Configuration
{
    internal class RepairOrderPartConfiguration : IEntityTypeConfiguration<RepairOrderPart>
    {
        public void Configure(EntityTypeBuilder<RepairOrderPart> entity)
        {
            entity
                .HasKey(rp => new { rp.RepairOrderId, rp.PartId });

            entity
                .HasOne(rp => rp.RepairOrder)
                .WithMany(ro => ro.RepairOrderParts)
                .HasForeignKey(rp => rp.RepairOrderId)
                .OnDelete(DeleteBehavior.NoAction);

            entity
                .HasOne(rp => rp.Part)
                .WithMany(p => p.RepairOrderParts)
                .HasForeignKey(rp => rp.PartId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
