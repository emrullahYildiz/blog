
using System.Collections.Generic;
using blog.Models;

namespace blog.Interfaces{
    public interface IArticle
    {
        List<Article> getArticles(int count);
    }
}