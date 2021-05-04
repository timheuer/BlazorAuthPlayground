using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
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

        public async Task OnGet(string redirectUri)
        {
            await HttpContext.SignOutAsync("Cookies", new AuthenticationProperties
            {
                RedirectUri = _config.GetValue<string>("RedirectUri")
            });
        }
    }
}