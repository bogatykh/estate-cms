using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class PhotoMappingProfile : Profile
    {
        public PhotoMappingProfile()
        {
            CreateMap<Photo, PhotoModel>();
        }
    }
}
