using System;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{
    [EnableCors("CORS")]
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
            Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:3000/");
            Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            var response = await _userService.GetUserAccount(Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserModel loginModel)
        {
            var response = await _userService.Login(loginModel);
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel registerModel)
        {
            var response = await _userService.Register(registerModel);
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }
    }
}