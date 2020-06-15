using System;

namespace LearnElectronics.WebApi.Tests.Models
{
    public class Comment
    { 
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int LectureId { get; set; }

    }
}
