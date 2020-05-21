using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Services.Contracts.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
