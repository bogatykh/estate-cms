using AutoMapper;
using Tti.Estate.Data.Entities;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Mapping
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<Transaction, TransactionListItemModel>();

            CreateMap<Transaction, TransactionModel>().
                ReverseMap().
                ForMember(x => x.User, x => x.Ignore()).
                ForMember(x => x.Status, x => x.Ignore()).
                ForMember(x => x.Created, x => x.Ignore()).
                ForMember(x => x.Modified, x => x.Ignore());

            CreateMap<Transaction, TransactionEditModel>().
                IncludeBase<Transaction, TransactionModel>().
                ReverseMap().
                IncludeBase<TransactionModel, Transaction>();

            CreateMap<Transaction, TransactionDetailsModel>().
                IncludeBase<Transaction, TransactionEditModel>().
                ForMember(x => x.Comments, x => x.Ignore()).
                ReverseMap().
                IncludeBase<TransactionEditModel, Transaction>();
        }
    }
}
