using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class LigthLectureModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
