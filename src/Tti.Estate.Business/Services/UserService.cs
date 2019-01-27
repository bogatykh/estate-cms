using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System;
using System.Data;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Exceptions;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IStringLocalizer _localizer;

        public UserService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher, IStringLocalizer<UserService> localizer)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _localizer = localizer;
        }

        public async Task<User> GetAsync(long id)
        {
            return await _userRepository.GetAsync(id);
        }

        public async Task<IPagedResult<User>> ListAsync(int pageIndex, int pageSize)
        {
            var filterSpecification = new UserFilterSpecification();
            var filterPaginatedSpecification = new UserFilterPaginatedSpecification(pageIndex * pageSize, pageSize);

            var items = await _userRepository.ListAsync(filterPaginatedSpecification);
            var totalItems = await _userRepository.CountAsync(filterSpecification);

            return new PagedResult<User>(pageIndex, pageSize, totalItems, items);
        }

        public async Task CreateAsync(User user, string password)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            await _userRepository.CreateAsync(user);
        }

        public async Task UpdateAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            await ValidateAsync(user);

            try
            {
                await _userRepository.DeleteAsync(user);
            }
            catch (DBConcurrencyException)
            {
                user.Status = UserStatus.Deleted;

                await _userRepository.UpdateAsync(user);
            }
        }

        public async Task BlockAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.Status = UserStatus.Blocked;

            await _userRepository.UpdateAsync(user);
        }

        public async Task UnblockAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.Status = UserStatus.Active;

            await _userRepository.UpdateAsync(user);
        }

        private async Task ValidateAsync(User user)
        {
            // TODO: Refactor to use specifications pattern
            if (await _userRepository.CountAsync(new UserFilterSpecification(onlyActive: true, role: UserRole.Manager, excludeId: user.Id)) == 0)
            {
                throw new DomainException(_localizer.GetString("LastActiveManager"));
            }
        }

        public async Task<User> ValidateAsync(string userName, string password)
        {
            var user = await _userRepository.SingleAsync(new UserFilterSpecification(onlyActive: true, userName: userName));

            if (user != null &&
                _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password) == PasswordVerificationResult.Success)
            {
                return user;
            }

            return null;
        }
    }
}
