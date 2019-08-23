using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer> , ICustomerRepository
    {
        public CustomerRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
