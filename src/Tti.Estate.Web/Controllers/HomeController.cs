using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tti.Estate.Data;
using Tti.Estate.Web.Models;

namespace Tti.Estate.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public HomeController(AppDbContext context)
        {

        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult SetCulture(string culture, string returnUrl)
        {
            string cookieVal = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture));

            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, cookieVal);

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AllowAnonymous]
        public IActionResult StatusCode()
        {
            return View();
        }
    }
}
