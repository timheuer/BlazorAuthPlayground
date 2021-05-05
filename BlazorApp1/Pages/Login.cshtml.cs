using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace BlazorApp1.Pages
{
    public class LoginModel : PageModel
    {
        private IConfiguration _config;

        public LoginModel(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task OnGet(string redirectUri)
        {
            await HttpContext.ChallengeAsync("Strava",
                   new AuthenticationProperties
                   {
                       RedirectUri = _config.GetValue<string>("RedirectUri"),
                       IsPersistent = true
                   });

        }
    }
}
