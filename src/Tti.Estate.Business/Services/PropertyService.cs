using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IPropertyValidator _propertyValidator;

        public PropertyService(IPropertyRepository propertyRepository, IPropertyValidator propertyValidator)
        {
            _propertyRepository = propertyRepository;
            _propertyValidator = propertyValidator;
        }

        public async Task CreateAsync(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Create);

            await _propertyRepository.CreateAsync(property);
        }

        public async Task<Property> GetAsync(long id)
        {
            var spec = new PropertyFilterSpecification(id: id);

            return await _propertyRepository.SingleAsync(spec);
        }

        public async Task<IPagedResult<Property>> ListAsync(int pageIndex, int pageSize,
            long? userId = null,
            PropertyType? propertyType = null,
            PropertyStatus? status = null,
            TransactionType? transactionType = null,
            decimal? priceFrom = null,
            decimal? priceTo = null)
        {
            var filterSpecification = new PropertyFilterSpecification(
                userId: userId,
                propertyType: propertyType,
                status: status,
                transactionType: transactionType,
                priceFrom: priceFrom,
                priceTo: priceTo
            );
            var filterPaginatedSpecification = new PropertyFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: userId,
                propertyType: propertyType,
                status: status,
                transactionType: transactionType,
                priceFrom: priceFrom,
                priceTo: priceTo
            );

            var items = await _propertyRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _propertyRepository.CountAsync(filterSpecification);
            
            return new PagedResult<Property>(pageIndex, pageSize, totalItems, items);
        }

        public async Task UpdateAsync(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Update);

            property.Modified = DateTime.UtcNow;

            await _propertyRepository.UpdateAsync(property);
        }

        public async Task<OperationResult> DeleteAsync(long id)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return OperationResult.NotFound;
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Delete);

            property.Status = PropertyStatus.Deleted;

            await _propertyRepository.UpdateAsync(property);

            return OperationResult.Success;
        }
    }
}
