using System;
using System.Collections;
using System.Collections.Generic;

namespace ApiRest.Models
{
    public class Post
    {
        public string PostID { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }

        public User User { get; set; }


        public ICollection<Comment> SubComment { get; set; }

    }
}