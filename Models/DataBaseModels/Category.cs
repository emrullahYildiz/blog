
using System.Collections.Generic;

namespace blog.Models{
    public class Category{
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategorySequance { get; set; }
        public ICollection<Article> Article { get; set; }
    }
}