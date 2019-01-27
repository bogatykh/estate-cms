using AutoMapper;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CommonMappingProfile : Profile
    {
        public CommonMappingProfile()
        {
            //CreateMap<IPagedResult, PagedResultModel>();

            //CreateMap(typeof(IPagedResult<>), typeof(PagedResultModel<>)).
            //    IncludeBase(typeof(IPagedResult), typeof(PagedResultModel));
        }
    }
}
