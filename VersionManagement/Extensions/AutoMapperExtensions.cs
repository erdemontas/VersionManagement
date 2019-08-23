using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VersionManagement.DTOs;
using VersionManagement.Models;

namespace VersionManagement.Extensions
{
    public static class AutoMapperExtensions
    {
        public static IMappingExpression<TSource, TDestination> MapSharedProperties<TSource, TDestination, TProperty>(
        this IMappingExpression<TSource, TDestination> map,
        Expression<Func<TSource, TProperty>> sourceMember,
        Expression<Func<TDestination, object>> targetMember)
            where TSource : SharedEntitiesDTO
            where TDestination : SharedEntities
        {
            map
                .ForMember(member => member.Id, member => member.Ignore())
                .ForMember(member => member.CreatedDate, member => member.Ignore())
                .ForMember(member => member.ModifiedDate, member => member.Ignore());
            return map;
        }
    }
}
