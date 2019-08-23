using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class ChangeLogRepository : RepositoryBase<ChangeLog>, IChangeLogRepository
    {
        public ChangeLogRepository(VManagementContext vmContext) : base(vmContext)
        {
        }
    }
}
