using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Business.Services
{
    internal class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPropertyValidator _propertyValidator;
        private readonly IIdentityService _identityService;

        public PropertyService(IPropertyRepository propertyRepository, ICommentRepository commentRepository, IUnitOfWork unitOfWork, IPropertyValidator propertyValidator, IIdentityService identityService)
        {
            _propertyRepository = propertyRepository;
            _commentRepository = commentRepository;
            _unitOfWork = unitOfWork;
            _propertyValidator = propertyValidator;
            _identityService = identityService;
        }

        public async Task CreateAsync(Property property)
        {
            if (property == null)
            {
                throw new ArgumentNullException(nameof(property));
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Create);

            _propertyRepository.Create(property);

            await _unitOfWork.SaveAsync();
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
            long? countyId = null,
            long? cityId = null,
            decimal? priceFrom = null,
            decimal? priceTo = null,
            string telephone = null,
            long? code = null)
        {
            var filterSpecification = new PropertyFilterSpecification(
                userId: userId,
                propertyType: propertyType,
                status: status,
                transactionType: transactionType,
                countyId: countyId,
                cityId: cityId,
                priceFrom: priceFrom,
                priceTo: priceTo,
                telephone: telephone,
                id: code
            );
            var filterPaginatedSpecification = new PropertyFilterPaginatedSpecification(pageIndex * pageSize, pageSize,
                userId: userId,
                propertyType: propertyType,
                status: status,
                transactionType: transactionType,
                countyId: countyId,
                cityId: cityId,
                priceFrom: priceFrom,
                priceTo: priceTo,
                telephone: telephone,
                id: code
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

            _propertyRepository.Update(property);

            await _unitOfWork.SaveAsync();
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

            _propertyRepository.Update(property);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> ProcessAsync(long id, PropertyStatus status, string comment = null)
        {
            if (status != PropertyStatus.Realized && status != PropertyStatus.Reserved)
            {
                return OperationResult.BadRequest;
            }

            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return OperationResult.NotFound;
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Process);

            property.Status = status;

            _propertyRepository.Update(property);
            
            if (!string.IsNullOrEmpty(comment))
            {
                // TODO: May be call service?
                _commentRepository.Create(new Comment()
                {
                    UserId = _identityService.GetUserId(),
                    PropertyId = id,
                    Text = comment
                });
            }

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> ActivateAsync(long id)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return OperationResult.NotFound;
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Activate);

            property.Status = PropertyStatus.Active;

            _propertyRepository.Update(property);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }
    }
}
