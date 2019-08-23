using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class ComponentRepository : RepositoryBase<Component> , IComponentRepository
    {
        public ComponentRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
