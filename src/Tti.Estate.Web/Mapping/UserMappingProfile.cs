using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserListItemModel>();

            CreateMap<User, UserModel>().
                ReverseMap();

            CreateMap<User, UserItemModel>().
                IncludeAllDerived();

            CreateMap<User, UserEditModel>().
                IncludeBase<User, UserModel>().
                ReverseMap().
                IncludeBase<UserModel, User>();

            CreateMap<User, UserDetailsModel>().
                IncludeBase<User, UserEditModel>().
                ReverseMap().
                IncludeBase<UserEditModel, User>();

            CreateMap<User, SelectListItem>().
                ForMember(x => x.Text, x => x.MapFrom(y => $"{y.FirstName} {y.LastName}")).
                ForMember(x => x.Value, x => x.MapFrom(y => y.Id)).
                ForAllOtherMembers(x => x.Ignore());
        }
    }
}
