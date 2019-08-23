using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class ChangeLogTypeRepository : RepositoryBase<ChangeLogType> , IChangeLogTypeRepository
    {
        public ChangeLogTypeRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
