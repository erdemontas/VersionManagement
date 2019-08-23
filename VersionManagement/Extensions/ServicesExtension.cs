﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VersionManagement.DTOs;
using VersionManagement.Validators;

namespace VersionManagement.Extensions
{
    public static class ServicesExtension
    {
        public static void AddDTOValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ChangeLogDTO>, ChangeLogDTOValidator>();
            services.AddTransient<IValidator<ChangeLogTypeDTO>, ChangeLogTypeDTOValidator>();
            services.AddTransient<IValidator<ComponentDTO>, ComponentDTOValidator>();
            services.AddTransient<IValidator<ComponentTypeDTO>, ComponentTypeDTOValidator>();
            services.AddTransient<IValidator<CustomerDTO>, CustomerDTOValidator>();
            services.AddTransient<IValidator<CustomerProductDTO>, CustomerProductDTOValidator>();
            services.AddTransient<IValidator<ProductDTO>, ProductDTOValidator>();
            services.AddTransient<IValidator<PublishActivityDTO>, PublishActivityDTOValidator>();
            services.AddTransient<IValidator<VersionDTO>, VersionDTOValidator>();
        }
    }
}
