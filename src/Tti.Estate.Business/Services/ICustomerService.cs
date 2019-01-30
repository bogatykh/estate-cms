using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Business.Services
{
    public interface ICustomerService
    {
        Task CreateAsync(Customer customer);
        Task<Customer> GetAsync(long id);
        Task<IPagedResult<Customer>> ListAsync(int pageIndex, int pageSize,
            string term = null,
            long? userId = null);
        Task UpdateAsync(Customer customer);
        Task<OperationResult> DeleteAsync(long id);
    }
}
