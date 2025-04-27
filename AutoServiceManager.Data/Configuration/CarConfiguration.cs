using AutoServiceManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoServiceManager.Data.Configuration
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> entity)
        {
            entity
                .HasKey(c => c.Id);

            entity
                .Property(c => c.RegNumber)
                .IsRequired()
                .HasMaxLength(10);

            entity
                .Property(c => c.Make)
                .IsRequired()
                .HasMaxLength(100);

            entity
                .Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(100);

            entity
                .Property(c => c.Year)
                .IsRequired();

            entity
                .HasOne(c => c.Customer)
                .WithMany(cus => cus.Cars)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
