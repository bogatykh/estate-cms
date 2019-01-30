using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<City, SelectListItem>().
                ForMember(x => x.Text, x => x.MapFrom(y => y.Name)).
                ForMember(x => x.Value, x => x.MapFrom(y => y.Id)).
                ForAllOtherMembers(x => x.Ignore());

            CreateMap<City, CityListItemModel>();

            CreateMap<City, CityItemModel>();
        }
    }
}
