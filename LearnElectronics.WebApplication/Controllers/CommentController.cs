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
    public class CommentController : Controller
    {

        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost("comment")]
        public async Task<IActionResult> AddComment([FromBody] AddCommentModel addCommentModel)
        {
            var response = await _commentService.AddComment(addCommentModel, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }


        [HttpPut("comment")]
        public async Task<IActionResult> EditComment([FromBody] EditCommentModel editCommentModel)
        {
            var response = await _commentService.EditComment(editCommentModel, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

        [HttpDelete("comment/{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var response = await _commentService.DeleteComment(id, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }

    }
}