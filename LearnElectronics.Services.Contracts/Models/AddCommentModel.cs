using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class AddCommentModel
    {
        public int LectureId { get; set; }
        public string Text { get; set; }
    }
}
