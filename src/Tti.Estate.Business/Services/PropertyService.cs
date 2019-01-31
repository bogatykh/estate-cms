﻿using System;
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
        private readonly IPropertyValidator _propertyValidator;
        private readonly IIdentityService _identityService;

        public PropertyService(IPropertyRepository propertyRepository, ICommentRepository commentRepository, IPropertyValidator propertyValidator, IIdentityService identityService)
        {
            _propertyRepository = propertyRepository;
            _commentRepository = commentRepository;
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
            decimal? priceTo = null,
            string telephone = null,
            long? code = null)
        {
            var filterSpecification = new PropertyFilterSpecification(
                userId: userId,
                propertyType: propertyType,
                status: status,
                transactionType: transactionType,
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

        public async Task<OperationResult> ProcessAsync(long id, PropertyStatus status, string comment = null)
        {
            var property = await _propertyRepository.GetAsync(id);

            if (property == null)
            {
                return OperationResult.NotFound;
            }

            await _propertyValidator.ValidateAsync(property, PropertyAction.Process);

            property.Status = status;

            await _propertyRepository.UpdateAsync(property);

            // TODO: Use Unit of Work
            if (!string.IsNullOrEmpty(comment))
            {
                // TODO: May be call service?
                await _commentRepository.CreateAsync(new Comment()
                {
                    UserId = _identityService.GetUserId(),
                    PropertyId = id,
                    Text = comment
                });
            }

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

            await _propertyRepository.UpdateAsync(property);

            return OperationResult.Success;
        }
    }
}
