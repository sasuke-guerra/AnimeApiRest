using System;
using System.Collections;
using System.Collections.Generic;

namespace ApiRest.Models
{
    public class Comment
    {
        public string CommentID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }

        public ICollection<SubComment> SubComment { get; set; }
    }

}


