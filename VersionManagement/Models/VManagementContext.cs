using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VersionManagement.DTOs;
using VersionManagement.Extensions;

namespace VersionManagement.Models
{
    public class VManagementContext : DbContext
    {
        public VManagementContext(DbContextOptions<VManagementContext> options)
            : base(options)
        { }

        public DbSet<ChangeLog> ChangeLog { get; set; } // DTO
        public DbSet<ChangeLogType> ChangeLogType { get; set; }
        public DbSet<Component> Component { get; set; } // DTO
        public DbSet<ComponentType> ComponentType { get; set; }
        public DbSet<Customer> Customer { get; set; } // DTO
        public DbSet<CustomerProduct> CustomerProduct { get; set; }
        public DbSet<Product> Product { get; set; } // DTO
        public DbSet<PublishActivity> PublishActivity { get; set; }
        public DbSet<Version> Version { get; set; } // DTO

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configure<ChangeLog>();
            modelBuilder.Entity<ChangeLog>().HasOne(x => x.ChangeLogType).WithMany().HasForeignKey(x => x.ChangeLogTypeId);
            modelBuilder.Entity<ChangeLog>().HasOne(x => x.Version).WithMany().HasForeignKey(x => x.VersionId);
            modelBuilder.Configure<ChangeLogType>();
            modelBuilder.Configure<Component>();
            modelBuilder.Entity<Component>().HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);
            modelBuilder.Configure<ComponentType>();
            modelBuilder.Configure<Customer>();
            modelBuilder.Configure<CustomerProduct>();
            modelBuilder.Entity<CustomerProduct>().HasOne(x => x.Customer).WithMany().HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<CustomerProduct>().HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId);
            //modelBuilder.Entity<CustomerProduct>().HasMany(x => Version).WithOne().HasForeignKey(x => x.Id);
            modelBuilder.Configure<Product>();
            modelBuilder.Configure<PublishActivity>();
            //modelBuilder.Entity<PublishActivity>().HasMany(x => CustomerProduct).WithOne().HasForeignKey(x => x.Id);
            //modelBuilder.Entity<PublishActivity>().HasMany(x => Version).WithOne().HasForeignKey(x => x.Id);
            modelBuilder.Configure<Version>();
            //modelBuilder.Entity<Version>().HasMany(x => Component).WithOne().HasForeignKey(x => x.Id);
        }
    }
}