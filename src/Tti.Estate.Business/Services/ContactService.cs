using System.Collections.Generic;
using System.Threading.Tasks;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IContactValidator _contactValidator;

        public ContactService(IContactRepository contactRepository, IContactValidator contactValidator)
        {
            _contactRepository = contactRepository;
            _contactValidator = contactValidator;
        }

        public async Task CreateAsync(Contact contact)
        {
            await _contactValidator.ValidateAsync(contact, ContactAction.Create);

            await _contactRepository.CreateAsync(contact);
        }

        public async Task<Contact> GetAsync(long id)
        {
            return await _contactRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Contact>> ListAsync(long? customerId = null, long? propertyId = null)
        {
            var spec = new ContactFilterSpecification(
                customerId: customerId,
                propertyId: propertyId
            );

            return await _contactRepository.ListAsync(spec);
        }

        public async Task UpdateAsync(Contact contact)
        {
            await _contactRepository.UpdateAsync(contact);
        }

        public async Task DeleteAsync(Contact contact)
        {
            await _contactRepository.DeleteAsync(contact);
        }
    }
}
