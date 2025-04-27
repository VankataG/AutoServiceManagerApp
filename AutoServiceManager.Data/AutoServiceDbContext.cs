using System.Data;
using AutoServiceManager.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoServiceManager.Data
{
    public class AutoServiceDbContext : IdentityDbContext
    {
        public AutoServiceDbContext(DbContextOptions<AutoServiceDbContext> options)
                : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<RepairOrder> RepairOrders { get; set; }

        public virtual DbSet<Part> Parts { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<RepairOrderPart> RepairOrderParts { get; set; }

        public virtual DbSet<RepairOrderEmployee> RepairOrderEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RepairOrderPart>()
                .HasKey(rp => new { rp.RepairOrderId, rp.PartId });

            modelBuilder.Entity<RepairOrderEmployee>()
                .HasKey(re => new { re.RepairOrderId, re.EmployeeId });
        }
    }
}
