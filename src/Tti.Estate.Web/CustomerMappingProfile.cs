using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Customer, CustomerListItemModel>().
                ForMember(x => x.User, x => x.MapFrom(y => y.User.LastName));

            CreateMap<Customer, CustomerModel>().
                ForMember(x => x.Users, x => x.Ignore()).
                ReverseMap();

            CreateMap<Customer, CustomerEditModel>().
                IncludeBase<Customer, CustomerModel>().
                ReverseMap().
                IncludeBase<CustomerModel, Customer>();

            CreateMap<Customer, CustomerDetailsModel>().
                IncludeBase<Customer, CustomerEditModel>().
                ForMember(x => x.Contacts, x => x.Ignore()).
                ForMember(x => x.Comments, x => x.Ignore()).
                ReverseMap().
                IncludeBase<CustomerEditModel, Customer>();
        }
    }
}
