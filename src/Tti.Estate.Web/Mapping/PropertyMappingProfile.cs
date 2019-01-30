using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class PropertyMappingProfile : Profile
    {
        public PropertyMappingProfile()
        {
            CreateMap<Property, PropertyListItemModel>();

            CreateMap<Property, PropertyModel>().
                ReverseMap().
                ForMember(x => x.Status, x => x.Ignore()).
                ForMember(x => x.Created, x => x.Ignore()).
                ForMember(x => x.Modified, x => x.Ignore()).
                ForMember(x => x.User, x => x.Ignore()).
                ForMember(x => x.County, x => x.Ignore()).
                ForMember(x => x.City, x => x.Ignore());

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
