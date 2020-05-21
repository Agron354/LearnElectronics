using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Database
{
    public class CompletedLecture
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public int UserId { get; set; }
    }
}
