using Microsoft.AspNetCore.Http;
using Tti.Estate.Infrastructure.Extensions;
using Tti.Estate.Infrastructure.Services;

namespace Tti.Estate.Web.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public long GetUserId()
        {
            return _httpContextAccessor.HttpContext.User.GetUserId();
        }
    }
}
