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
                ReverseMap();

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
