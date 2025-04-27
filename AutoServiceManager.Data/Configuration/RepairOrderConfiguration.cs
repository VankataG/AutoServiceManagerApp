using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoServiceManager.Data.Configuration
{
    internal class RepairOrderConfiguration : IEntityTypeConfiguration<RepairOrder>
    {
        public void Configure(EntityTypeBuilder<RepairOrder> entity)
        {
            entity
                .HasKey(ro => ro.Id);

            entity
                .HasOne(ro => ro.Car)
                .WithMany(c => c.RepairOrders)
                .HasForeignKey(ro => ro.CarId)
                .OnDelete(DeleteBehavior.NoAction);

            entity
                .Property(ro => ro.Problem)
                .IsRequired()
                .HasMaxLength(500);

        }
    }
}
