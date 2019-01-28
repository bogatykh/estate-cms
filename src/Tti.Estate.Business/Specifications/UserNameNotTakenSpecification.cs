using System.Threading.Tasks;
using Tti.Estate.Data.Entities;
using Tti.Estate.Data.Repositories;
using Tti.Estate.Data.Specifications;

namespace Tti.Estate.Business.Specifications
{
    public class UserNameNotTakenSpecification : IAsyncSpecification<User>
    {
        private readonly IUserRepository _userRepository;

        public UserNameNotTakenSpecification(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> IsSatisfiedByAsync(User entity)
        {
            return !await _userRepository.AnyAsync(new UserFilterSpecification(userName: entity.UserName, excludeId: entity.Id));
        }
    }
}
