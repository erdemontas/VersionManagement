using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Configure<T>(this ModelBuilder self)
            where T : SharedEntities
        {
            self.Entity<T>().Property(x => x.Id).HasDefaultValueSql("newid()");
            self.Entity<T>().Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
            self.Entity<T>().Property(x => x.IsActive).HasDefaultValue(true);
            self.Entity<T>().Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
