using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class LectureModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public TestDataModel Test { get; set; }
        public List<CommentModel> Comments { get; set; }
        public bool IsCompleted { get; set; }

        public LectureModel()
        {
            Comments = new List<CommentModel>();
        }

    }
}
