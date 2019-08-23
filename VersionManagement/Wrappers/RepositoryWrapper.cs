using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;
using VersionManagement.Repositories;

namespace VersionManagement.Wrappers
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private VManagementContext vmContext;

        public RepositoryWrapper(VManagementContext vmContext)
        {
            this.vmContext = vmContext;
            changeLog = new Lazy<IChangeLogRepository>(() => new ChangeLogRepository(vmContext));
            changeLogType = new Lazy<IChangeLogTypeRepository>(() => new ChangeLogTypeRepository(vmContext));
            component = new Lazy<IComponentRepository>(() => new ComponentRepository(vmContext));
            componentType = new Lazy<IComponentTypeRepository>(() => new ComponentTypeRepository(vmContext));
            customer = new Lazy<ICustomerRepository>(() => new CustomerRepository(vmContext));
            customerProduct = new Lazy<ICustomerProductRepository>(() => new CustomerProductRepository(vmContext));
            product = new Lazy<IProductRepository>(() => new ProductRepository(vmContext));
            publishActivity = new Lazy<IPublishActivityRepository>(() => new PublishActivityRepository(vmContext));
            version = new Lazy<IVersionRepository>(() => new VersionRepository(vmContext));
        }
        //fields
        private Lazy<IChangeLogRepository> changeLog;
        private Lazy<IChangeLogTypeRepository> changeLogType;
        private Lazy<IComponentRepository> component;
        private Lazy<IComponentTypeRepository> componentType;
        private Lazy<ICustomerRepository> customer;
        private Lazy<ICustomerProductRepository> customerProduct;
        private Lazy<IProductRepository> product;
        private Lazy<IPublishActivityRepository> publishActivity;
        private Lazy<IVersionRepository> version;
        //props
        public IChangeLogRepository ChangeLog => changeLog.Value;
        public IChangeLogTypeRepository ChangeLogType => changeLogType.Value;
        public IComponentRepository Component => component.Value;
        public IComponentTypeRepository ComponentType => componentType.Value;
        public ICustomerRepository Customer => customer.Value;
        public ICustomerProductRepository CustomerProduct => customerProduct.Value;        
        public IProductRepository Product => product.Value;        
        public IPublishActivityRepository PublishActivity => publishActivity.Value;
        public IVersionRepository Version => version.Value;

        public void Save()
        {
            vmContext.SaveChanges();
        }
    }
}
