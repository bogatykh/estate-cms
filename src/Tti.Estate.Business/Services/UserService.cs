using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Tti.Estate.Business.Dto;
using Tti.Estate.Business.Validators;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserValidator _userValidator;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork, IUserValidator userValidator, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _userValidator = userValidator;
            _passwordHasher = passwordHasher;
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

            await _userValidator.ValidateAsync(user, UserAction.Create);

            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            _userRepository.Create(user);

            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _userRepository.Update(user);

            await _unitOfWork.SaveAsync();
        }

        public async Task<OperationResult> DeleteAsync(long id)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return OperationResult.NotFound;
            }

            await _userValidator.ValidateAsync(user, UserAction.Delete);

            user.Status = UserStatus.Deleted;

            _userRepository.Update(user);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> BlockAsync(long id)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return OperationResult.NotFound;
            }

            await _userValidator.ValidateAsync(user, UserAction.Block);

            user.Status = UserStatus.Blocked;

            _userRepository.Update(user);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> UnblockAsync(long id)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return OperationResult.NotFound;
            }

            user.Status = UserStatus.Active;

            _userRepository.Update(user);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
        }

        public async Task<OperationResult> ChangePasswordAsync(long id, string password)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return OperationResult.NotFound;
            }

            user.PasswordHash = _passwordHasher.HashPassword(user, password);

            _userRepository.Update(user);

            await _unitOfWork.SaveAsync();

            return OperationResult.Success;
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
