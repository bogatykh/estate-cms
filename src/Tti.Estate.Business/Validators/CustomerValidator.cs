using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class CustomerValidator : ICustomerValidator
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IStringLocalizer _localizer;

        public CustomerValidator(ICustomerRepository customerRepository, IStringLocalizer<CustomerValidator> localizer)
        {
            _customerRepository = customerRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(Customer entity, CustomerAction action)
        {
            switch (action)
            {
                case CustomerAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                case CustomerAction.Update:
                    break;
                case CustomerAction.Delete:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(Customer entity)
        {
        }
    }
}
