
using System.Collections.Generic;
using System.Linq;
using blog.Interfaces;
using blog.Models;

namespace blog.Implementers{
    public class ArticleContext : IArticle
    {
        private readonly DatabaseContext databaseContext;
        public ArticleContext(DatabaseContext databaseContext){
            this.databaseContext = databaseContext;
        }
        public List<Article> getArticles(int count = 0)
        {
            //if we want first n row , assign a value to count variable
            List<Article> articles;
            if(count == 0){
                articles = databaseContext.Articles.ToList();
            }else{
                articles = databaseContext.Articles.Take(count).ToList();
            }
            return articles;
        }
    }
}