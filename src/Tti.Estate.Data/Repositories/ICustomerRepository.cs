﻿using System.Threading.Tasks;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>, IReadRepository<Customer>, IWriteRepository<Customer>
    {
        Task<IPagedResult<Customer>> SearchAsync();
    }
}
