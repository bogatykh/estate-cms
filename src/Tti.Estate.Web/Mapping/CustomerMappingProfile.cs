using AutoMapper;
using System.Linq;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Customer, CustomerListItemModel>().
                ForMember(x => x.Contact, x => x.MapFrom(y => y.Contacts.FirstOrDefault()));

            CreateMap<Customer, CustomerModel>().
                ForMember(x => x.Users, x => x.Ignore()).
                ReverseMap().
                ForMember(x => x.Created, x => x.Ignore()).
                ForMember(x => x.Modified, x => x.Ignore()).
                ForMember(x => x.User, x => x.Ignore());

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
