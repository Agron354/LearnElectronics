using System;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Models;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{

    [ApiController]
    [EnableCors("CORS")]
    public class LikeController : Controller
    {

        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }

        [HttpPost("like")]
        public async Task<IActionResult> LikeComment([FromBody] int commentId)
        {
            var response = await _likeService.LikeComment(commentId, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }


        [HttpPost("dislike")]
        public async Task<IActionResult> DislikeComment([FromBody] int commentId)
        {
            var response = await _likeService.DislikeComment(commentId, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }


    }
}