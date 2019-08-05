using System.Collections;
using System;

namespace ApiRest.Models {

    public class SubComment
    {

        public string SubCommentID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

        public User User { get; set; }
        public Comment Comment { get; set; }
    }
}