﻿using System;
using System.Net;
using System.Threading.Tasks;
using LearnElectronics.Services.Contracts.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearnElectronics.WebApplication.Controllers
{
    [EnableCors("CORS")]
    public class LectureController : Controller
    {
        private readonly ILectureService _lectureService;

        public LectureController(ILectureService lectureService)
        {
            _lectureService = lectureService;
        }

        [HttpGet("lecture/{id}")]
        public async Task<IActionResult> GetLecture(int id)
        {
            var response = await _lectureService.GetLecture(id, Convert.ToInt32(Request.Cookies["userId"]));
            if (response.Code <= HttpStatusCode.PermanentRedirect) { return Json(response.Data); }
            else { return BadRequest(); }
        }
    }
}