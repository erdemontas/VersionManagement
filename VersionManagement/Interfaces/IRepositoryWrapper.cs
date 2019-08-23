using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Interfaces
{
    public interface IRepositoryWrapper
    {
        IChangeLogRepository ChangeLog { get; }
        IChangeLogTypeRepository ChangeLogType { get; }
        IComponentRepository Component { get; }
        IComponentTypeRepository ComponentType { get; }
        ICustomerProductRepository CustomerProduct { get; }
        IProductRepository Product { get; }
        IPublishActivityRepository PublishActivity { get; }
        IVersionRepository Version { get; }
        ICustomerRepository Customer { get; }
        void Save();
    }
}
