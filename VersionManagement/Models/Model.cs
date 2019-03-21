using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VersionManagement.Models
{
    public class VersionDatabaseModel : DbContext
    {
        public VersionDatabaseModel(DbContextOptions<VersionDatabaseModel> options)
            : base(options)
        { }

        public DbSet<ChangeLog> ChangeLog { get; set; }
        public DbSet<ChangeLogType> ChangeLogType { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<ComponentType> ComponentType { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerProduct> CustomerProduct { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<PublishActivity> PublishActivity { get; set; }
        public DbSet<Version> Version { get; set; }


    }

  
}