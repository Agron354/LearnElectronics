using System;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("account")]
        public async Task<IActionResult> GetUserAccount()
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append("name", "123", cookieOptions);
            var userId = Request.Cookies["userId"];
            var response = await _userService.GetUserAccount(Convert.ToInt32(userId));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserModel loginModel)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append("name", "123", cookieOptions);
            var response = await _userService.Login(loginModel);
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel registerModel)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append("name", "123", cookieOptions);
            var response = await _userService.Register(registerModel);
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }
    }
}