using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OtoMoto.Models.Input;
using OtoMoto.Services;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OtoMoto.Pages.Account
{
    public class SignInModel : PageModel
    {
        private readonly AccountService _service;

        public SignInModel(AccountService _service)
        {
            this._service = _service;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnGetLogout()
        {
            await this.HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public async Task<IActionResult> OnPost(AccountInfo info)
        {
            if (info == null || string.IsNullOrEmpty(info.Email))
            {
                TempData["ErrorMessage"] = "Niepoprawne dane logowania.";
                return RedirectToPage("SignIn");
            }

            var user = await _service.GetUserOrNull(info);

            if (user == null)
            {
                TempData["ErrorMessage"] = "Niepoprawne dane logowania.";
                return RedirectToPage("SignIn");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role.Name),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls  
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync
            (
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties
            );

            return LocalRedirect("/");
        }
    }
}