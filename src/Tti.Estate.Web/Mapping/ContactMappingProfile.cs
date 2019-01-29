using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, ContactListItemModel>();

            CreateMap<Contact, ContactModel>().
                ReverseMap();

            CreateMap<Contact, ContactEditModel>().
                IncludeBase<Contact, ContactModel>().
                ReverseMap().
                IncludeBase<ContactModel, Contact>();

            CreateMap<Contact, ContactItemModel>().
                IncludeAllDerived();

            CreateMap<ContactListRequestModel, ContactFilterSpecification>();
        }
    }
}
