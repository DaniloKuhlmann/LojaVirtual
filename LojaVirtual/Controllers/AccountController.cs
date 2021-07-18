using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    [AllowAnonymous, Route("account")]
    public class AccountController : Controller
    {
        [Route("google-login")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("ResponseLogin") };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }
        [Route("microsoft-login")]
        public IActionResult MicrosoftLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("ResponseLogin") };
            return Challenge(properties, MicrosoftAccountDefaults.AuthenticationScheme);
            

        }
        [Route("ResponseLogin")]
        public async Task<IActionResult> ResponseLogin()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var resul = HttpContext.Response;
            var claims = result.Principal.Identities
                .FirstOrDefault().Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            return Json(claims);
        }
        [Route("GoogleResponseRegister")]

        public async Task<ActionResult> RegisterLogin()
        {
            var result = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var resul = HttpContext.Response;
            var claims = result.Principal.Identities
                .FirstOrDefault().Claims.Select(claim => new
                {
                    claim.Issuer,
                    claim.OriginalIssuer,
                    claim.Type,
                    claim.Value
                });

            return Json(claims);

        }
    }
}
