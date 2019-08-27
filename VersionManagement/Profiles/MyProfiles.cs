using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;
using VersionManagement.Models;
using AutoMapper;
using VersionManagement.Extensions;
using VersionManagement.Wrappers;
using VersionManagement.Interfaces;

namespace VersionManagement.Profiles
{
    public class MyProfiles : Profile
    {
        public MyProfiles()
        {
            //ChangeLog
            //Lite
            CreateMap<ChangeLog, LiteChangeLogDTO>();
            CreateMap<LiteChangeLogDTO, ChangeLog>();
            //Standard
            CreateMap<ChangeLog, ChangeLogDTO>().IncludeBase<ChangeLog, LiteChangeLogDTO>();
            
            CreateMap<ChangeLogDTO, ChangeLog>();
            //ChangeLogType
            CreateMap<ChangeLogType, ChangeLogTypeDTO>();
            CreateMap<ChangeLogTypeDTO, ChangeLogType>();
            //Lite Component
            CreateMap<Component, LiteComponentDTO>();
            CreateMap<LiteComponentDTO, Component>();
            //Standard Component
            CreateMap<Component, ComponentDTO>().IncludeBase<Component, LiteComponentDTO>();
            CreateMap<ComponentDTO, Component>();
            //Detailed Component
            CreateMap<Component, DetailedComponentDTO>().IncludeBase<Component, ComponentDTO>();
            CreateMap<DetailedComponentDTO, Component>();
            //ComponentType
            CreateMap<ComponentType, ComponentTypeDTO>();
            CreateMap<ComponentTypeDTO, ComponentType>();
            //Customer
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            //CustomerProduct
            //Lite
            CreateMap<CustomerProduct, LiteCustomerProductDTO>();
            CreateMap<LiteCustomerProductDTO, CustomerProduct>();
            //Standard
            CreateMap<CustomerProduct, CustomerProductDTO>().IncludeBase<CustomerProduct, LiteCustomerProductDTO>();
            CreateMap<CustomerProductDTO, CustomerProduct>();
            //Product
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            //Publish Activity
            CreateMap<PublishActivity, PublishActivityDTO>();
            CreateMap<PublishActivityDTO, PublishActivity>();
            //Version
            CreateMap<Models.Version, VersionDTO>();
            CreateMap<VersionDTO, Models.Version>();
        }
    }
}
