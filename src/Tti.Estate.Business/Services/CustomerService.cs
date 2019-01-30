using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerValidator _customerValidator;

        public CustomerService(ICustomerRepository customerRepository, ICustomerValidator customerValidator)
        {
            _customerRepository = customerRepository;
            _customerValidator = customerValidator;
        }

        public async Task CreateAsync(Customer customer)
        {
            await _customerValidator.ValidateAsync(customer, CustomerAction.Create);

            await _customerRepository.CreateAsync(customer);
        }

        public async Task<Customer> GetAsync(long id)
        {
            var spec = new CustomerFilterSpecification(id: id);

            return await _customerRepository.SingleAsync(spec);
        }

        public async Task<IPagedResult<Customer>> ListAsync(int pageIndex, int pageSize,
            string term = null,
            long? userId = null)
        {
            var filterSpecification = new CustomerFilterSpecification(
                userId: userId,
                term: term
            );
            var filterPaginatedSpecification = new CustomerFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: userId,
                term: term
            );

            var items = await _customerRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _customerRepository.CountAsync(filterSpecification);

            return new PagedResult<Customer>(pageIndex, pageSize, totalItems, items);
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _customerValidator.ValidateAsync(customer, CustomerAction.Update);

            customer.Modified = DateTime.UtcNow;

            await _customerRepository.UpdateAsync(customer);
        }

        public async Task<OperationResult> DeleteAsync(long id)
        {
            var customer = await _customerRepository.GetAsync(id);

            if (customer == null)
            {
                return OperationResult.NotFound;
            }

            await _customerValidator.ValidateAsync(customer, CustomerAction.Delete);

            await _customerRepository.DeleteAsync(customer);

            return OperationResult.Success;
        }
    }
}
