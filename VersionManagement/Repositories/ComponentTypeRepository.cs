using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class ComponentTypeRepository : RepositoryBase<ComponentType> , IComponentTypeRepository
    {
        public ComponentTypeRepository(VManagementContext vmContext) : base(vmContext)
        {
            
        }
    }
}
