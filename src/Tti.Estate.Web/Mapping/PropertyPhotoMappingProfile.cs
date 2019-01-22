using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class PropertyPhotoMappingProfile : Profile
    {
        public PropertyPhotoMappingProfile()
        {
            CreateMap<PropertyPhoto, PropertyPhotoModel>();
        }
    }
}
