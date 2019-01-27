using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Security.Claims;
using System.Threading.Tasks;
using Tti.Estate.Business.Services;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IStringLocalizer _localizer;

        public AccountController(IUserService userService, IStringLocalizer<AccountController> localizer)
        {
            _userService = userService;
            _localizer = localizer;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.ValidateAsync(userName: model.UserName, password: model.Password);

                if (user != null)
                {
                    ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

                    identity.AddClaim(new Claim(ClaimTypes.Sid, user.Id.ToString()));
                    identity.AddClaim(new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"));
                    identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName));
                    identity.AddClaim(new Claim(ClaimTypes.Surname, user.LastName));
                    identity.AddClaim(new Claim(ClaimTypes.Role, user.Role.ToString()));

                    await HttpContext.SignInAsync(
                      CookieAuthenticationDefaults.AuthenticationScheme,
                      new ClaimsPrincipal(identity),
                      new AuthenticationProperties()
                      {
                          IsPersistent = model.RememberMe
                      });

                    return LocalRedirect(returnUrl);
                }

                ModelState.AddModelError("", _localizer.GetString("LoginFailed"));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("~/");
        }
    }
}
