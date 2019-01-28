using Microsoft.Extensions.Localization;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Exceptions;
using Tti.Estate.Business.Specifications;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Business.Validators
{
    internal class UserValidator : IUserValidator
    {
        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer _localizer;

        public UserValidator(IUserRepository userRepository, IStringLocalizer<UserValidator> localizer)
        {
            _userRepository = userRepository;
            _localizer = localizer;
        }

        public async Task ValidateAsync(User entity, UserAction action)
        {
            switch (action)
            {
                case UserAction.Create:
                    await ValidateCreateAsync(entity);
                    break;
                case UserAction.Delete:
                    await ValidateDeleteAsync(entity);
                    break;
                case UserAction.Block:
                    await ValidateBlockAsync(entity);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private async Task ValidateCreateAsync(User entity)
        {
            var spec = new UserNameNotTakenSpecification(_userRepository);

            if (!await spec.IsSatisfiedByAsync(entity))
            {
                throw new DomainException(_localizer.GetString("UserNameTaken"));
            }
        }

        private async Task ValidateDeleteAsync(User entity)
        {
            await ValidateNotLastActiveManagerAsync(entity);
        }

        private async Task ValidateBlockAsync(User entity)
        {
            await ValidateNotLastActiveManagerAsync(entity);
        }

        private async Task ValidateNotLastActiveManagerAsync(User user)
        {
            // TODO: Refactor to validation rules
            var spec = new UserNotLastActiveManagerSpecification(_userRepository);

            if (!await spec.IsSatisfiedByAsync(user))
            {
                throw new DomainException(_localizer.GetString("LastActiveManager"));
            }
        }
    }
}
