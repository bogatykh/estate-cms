using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Web.Mapping
{
    public class RegionMappingProfile : Profile
    {
        public RegionMappingProfile()
        {
            CreateMap<Region, SelectListItem>().
                ForMember(x => x.Text, x => x.MapFrom(y => y.Name)).
                ForMember(x => x.Value, x => x.MapFrom(y => y.Id)).
                ForAllOtherMembers(x => x.Ignore());
        }
    }
}
