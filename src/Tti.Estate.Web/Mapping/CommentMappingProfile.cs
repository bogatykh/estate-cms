using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CommentMappingProfile : Profile
    {
        public CommentMappingProfile()
        {
            CreateMap<Comment, CommentListItemModel>().
                ForMember(x => x.User, x => x.MapFrom(y => y.User.LastName));

            CreateMap<Comment, CommentModel>().
                ReverseMap();

            CreateMap<CommentListRequestModel, CommentFilterSpecification>();
        }
    }
}
