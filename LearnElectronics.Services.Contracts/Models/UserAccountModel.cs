using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class UserAccountModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime RegistrationData { get; set; }
        public int CompletedTestCount { get; set; }
        public int CommentCount { get; set; }
        public int LectureProgress { get; set; }

    }
}
