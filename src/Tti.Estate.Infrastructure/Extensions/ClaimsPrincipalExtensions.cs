using System;
using System.Security.Claims;

namespace Tti.Estate.Infrastructure.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static long GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentNullException(nameof(principal));
            }

            return Convert.ToInt64(principal.FindFirstValue(ClaimTypes.Sid));
        }
    }
}
