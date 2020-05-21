using System;
using System.Collections.Generic;
using System.Text;

namespace LearnElectronics.Database
{
    public class Dislike
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
    }
}
