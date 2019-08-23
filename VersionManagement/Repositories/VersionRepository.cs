using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class VersionRepository : RepositoryBase<Models.Version>, IVersionRepository
    {
        public VersionRepository(VManagementContext vmContext) : base(vmContext)
        {
        }
    }
}
