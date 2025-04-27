using AutoServiceManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoServiceManager.Data.Configuration
{
    internal class PartConfiguration : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> entity)
        {
            entity
                .HasKey(p => p.Id);

            entity
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity
                .Property(p => p.Price)
                .IsRequired();
        }
    }
}
