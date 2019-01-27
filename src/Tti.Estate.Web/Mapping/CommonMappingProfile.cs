using AutoMapper;
using System;
using Tti.Estate.Business.Dto;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CommonMappingProfile : Profile
    {
        public CommonMappingProfile()
        {
            CreateMap<IPagedResult, PagedResultModel>().
                ForMember(x => x.TotalPages, x => x.MapFrom(y => (int)Math.Ceiling(y.TotalItems / (double)y.PageSize)));

            CreateMap(typeof(IPagedResult<>), typeof(PagedResultModel<>)).
                IncludeBase(typeof(IPagedResult), typeof(PagedResultModel));
        }
    }
}
