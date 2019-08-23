using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class CustomerProductRepository : RepositoryBase<CustomerProduct> , ICustomerProductRepository
    {
        public CustomerProductRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
