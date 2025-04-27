using AutoServiceManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoServiceManager.Data.Configuration
{
    internal class RepairOrderEmployeeConfiguration : IEntityTypeConfiguration<RepairOrderEmployee>
    {
        public void Configure(EntityTypeBuilder<RepairOrderEmployee> entity)
        {
            entity
                .HasKey(re => new { re.RepairOrderId, re.EmployeeId });

            entity
                .HasOne(re => re.RepairOrder)
                .WithMany(ro => ro.RepairOrderEmployees)
                .HasForeignKey(re => re.RepairOrderId)
                .OnDelete(DeleteBehavior.NoAction);

            entity
                .HasOne(re => re.Employee)
                .WithMany(e => e.RepairOrderEmployees)
                .HasForeignKey(re => re.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
