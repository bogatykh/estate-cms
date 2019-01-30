using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CountyMappingProfile : Profile
    {
        public CountyMappingProfile()
        {
            CreateMap<County, SelectListItem>().
                ForMember(x => x.Text, x => x.MapFrom(y => y.Name)).
                ForMember(x => x.Value, x => x.MapFrom(y => y.Id)).
                ForAllOtherMembers(x => x.Ignore());

            CreateMap<County, CountyItemModel>();
        }
    }
}
