
using System;
using System.Collections.Generic;

namespace blog.Models{
    public class Article{
        public int ArticleID { get; set; }
        public string ArticleHead { get; set; }
        public string ArticleAbstract { get; set; }
        public string ArticleImage { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleDate { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}