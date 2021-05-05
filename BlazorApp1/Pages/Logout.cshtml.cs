using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BlazorApp1.Pages
{
    public class LogoutModel : PageModel
    {
        private IConfiguration _config;

        public LogoutModel(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<ActionResult> OnGet(string redirectUri)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect(_config.GetValue<string>("RedirectUri"));
        }
    }
}