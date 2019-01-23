using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class PropertyMappingProfile : Profile
    {
        public PropertyMappingProfile()
        {
            CreateMap<Property, PropertyListItemModel>().
                ForMember(x => x.User, x => x.MapFrom(y => y.User.LastName));

            CreateMap<Property, PropertyModel>().
                ReverseMap();

            CreateMap<Property, PropertyEditModel>().
                IncludeBase<Property, PropertyModel>().
                ReverseMap().
                IncludeBase<PropertyModel, Property>();

            CreateMap<Property, PropertyDetailsModel>().
                IncludeBase<Property, PropertyEditModel>().
                ForMember(x => x.Contacts, x => x.Ignore()).
                ForMember(x => x.Comments, x => x.Ignore()).
                ReverseMap().
                IncludeBase<PropertyEditModel, Property>();
        }
    }
}
