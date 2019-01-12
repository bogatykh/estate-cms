using System;
using System.Security.Claims;
using System.Security.Principal;

namespace Tti.Estate.Web.Extensions
{
    public static class IIdentityExtensions
    {
        public static string GetPersonName(this IIdentity identity)
        {
            if (identity == null)
            {
                throw new ArgumentNullException(nameof(identity));
            }

            var claimsIdentity = (ClaimsIdentity)identity;

            return claimsIdentity.FindFirst("name")?.Value;
        }
    }
}
