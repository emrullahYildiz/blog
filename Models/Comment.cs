using System;

namespace blog.Models{
    public class Comment{
        public int CommentID { get; set; }
        public string CommentFullname { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public int ArticleID { get; set; }
        public Article Article { get; set;}
    }
}