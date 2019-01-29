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
            CreateMap<Comment, CommentListItemModel>();

            CreateMap<Comment, CommentModel>().
                ReverseMap().
                IgnoreAllPropertiesWithAnInaccessibleSetter();

            CreateMap<CommentListRequestModel, CommentFilterSpecification>();
        }
    }
}
