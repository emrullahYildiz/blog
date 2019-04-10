
using System.Collections.Generic;

namespace blog.Models{
    public class HomeViewModel{
        public List<Category> categories;
        public List<Article> articles;
        public int currentPageNumber;
    }
}