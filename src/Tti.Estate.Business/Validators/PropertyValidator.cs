using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class PropertyValidator : IPropertyValidator
    {
        private readonly IPropertyRepository _propertyRepository;
        private readonly IStringLocalizer _localizer;

        public PropertyValidator(IPropertyRepository propertyRepository, IStringLocalizer<PropertyValidator> localizer)
        {
            _propertyRepository = propertyRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(Property entity, PropertyAction action)
        {
            switch (action)
            {
                case PropertyAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                case PropertyAction.Update:
                    break;
                case PropertyAction.Delete:
                    break;
                case PropertyAction.Process:
                    break;
                case PropertyAction.Activate:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(Property entity)
        {
        }
    }
}
