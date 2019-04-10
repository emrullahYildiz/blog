
using System.Collections.Generic;
using blog.Models;

namespace blog.Interfaces{
    public interface IArticle
    {
        List<Article> getArticles(int count);
        List<Article> getArticles(int page,int articleCount);
        int getArticleCount();
        List<Article> searchArticle(string keywords);
    }
}