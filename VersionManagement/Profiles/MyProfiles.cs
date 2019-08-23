using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;
using VersionManagement.Models;
using AutoMapper;
using VersionManagement.Extensions;

namespace VersionManagement.Profiles
{
    public class MyProfiles : Profile
    {
        public MyProfiles()
        {
            //ChangeLog
            //Lite
            CreateMap<ChangeLog, LiteChangeLogDTO>();
            CreateMap<LiteChangeLogDTO, ChangeLog>()
                .MapSharedProperties(dto => dto,entity=>entity);
            //Standard
            CreateMap<ChangeLog, ChangeLogDTO>();
            CreateMap<ChangeLogDTO, ChangeLog>()
                .MapSharedProperties(dto => dto, entity => entity);
            //ChangeLogType
            CreateMap<ChangeLogType, ChangeLogTypeDTO>();
            CreateMap<ChangeLogTypeDTO, ChangeLogType>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Lite Component
            CreateMap<Component, LiteComponentDTO>();
            CreateMap<LiteComponentDTO, Component>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Standard Component
            CreateMap<Component, ComponentDTO>();
            CreateMap<ComponentDTO, Component>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Detailed Component
            CreateMap<Component, DetailedComponentDTO>();
            CreateMap<DetailedComponentDTO, Component>()
                .MapSharedProperties(dto => dto, entity => entity);
            //ComponentType
            CreateMap<ComponentType, ComponentTypeDTO>();
            CreateMap<ComponentTypeDTO, ComponentType>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Customer
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>()
                .MapSharedProperties(dto => dto, entity => entity);
            //CustomerProduct
            //Lite
            CreateMap<CustomerProduct, LiteCustomerProductDTO>();
            CreateMap<LiteCustomerProductDTO, CustomerProduct>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Standard
            CreateMap<CustomerProduct, CustomerProductDTO>();
            CreateMap<CustomerProductDTO, CustomerProduct>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Product
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Publish Activity
            CreateMap<PublishActivity, PublishActivityDTO>();
            CreateMap<PublishActivityDTO, PublishActivity>()
                .MapSharedProperties(dto => dto, entity => entity);
            //Version
            CreateMap<Models.Version, VersionDTO>();
            CreateMap<VersionDTO, Models.Version>()
                .MapSharedProperties(dto => dto, entity => entity);
        }
    }
}
