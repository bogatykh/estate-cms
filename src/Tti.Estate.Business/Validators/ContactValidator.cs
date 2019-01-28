using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Exceptions;
using Tti.Estate.Business.Specifications;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class ContactValidator : IContactValidator
    {
        private readonly IContactRepository _contactRepository;
        private readonly IStringLocalizer _localizer;

        public ContactValidator(IContactRepository contactRepository, IStringLocalizer<ContactValidator> localizer)
        {
            _contactRepository = contactRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(Contact entity, ContactAction action)
        {
            switch (action)
            {
                case ContactAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(Contact entity)
        {
            var spec = new ContactHasCustomerSpecification()
                .Or(new ContactHasPropertySpecification());

            if (!await spec.IsSatisfiedByAsync(entity))
            {
                throw new DomainException(_localizer.GetString("UnrelatedContact"));
            }
        }
    }
}
