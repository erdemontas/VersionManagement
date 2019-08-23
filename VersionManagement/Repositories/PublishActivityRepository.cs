using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class PublishActivityRepository : RepositoryBase<PublishActivity> , IPublishActivityRepository
    {
        public PublishActivityRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
