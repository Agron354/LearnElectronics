using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{
    [EnableCors("CORS")]
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpPost("test")]
        public async Task<IActionResult> CheckTest([FromBody] TestModel testModel)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:3000");
            Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            var response = await _testService.CheckTest(testModel, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }
    }
}