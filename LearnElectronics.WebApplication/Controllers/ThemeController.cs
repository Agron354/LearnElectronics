using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{
    public class ThemeController : Controller
    {
        private readonly IThemeService _themeService;

        public ThemeController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        [HttpGet("themes")]
        public async Task<IActionResult> GetThemes()
        {
            var response = await _themeService.GetThemes(Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }
    }
}