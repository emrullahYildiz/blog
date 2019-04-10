
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

        public List<Article> getArticleByCategory(int categoryId)
        {
            List<Article> articles = 
                        databaseContext.Articles.Where(query => query.CategoryID == categoryId).ToList();
            return articles;
        }

        public int getArticleCount()
        {
           return databaseContext.Articles.Count();
        }
        //Get all article
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
        
        public List<Article> getArticles(int page,int articleCount){
            List<Article> articles;
            try{
                //İf article is avaible in database between page*6 and page*6 + articleCount
                //page*6 = Every page has 6 post
                //example if page = 5 5*6 = 30 6th page starts 30th post
                articles = databaseContext.Articles.Skip(page*6).Take(articleCount).ToList()
                         ??databaseContext.Articles.SkipLast(6).ToList();
            }catch{
                //not avaible
                articles = databaseContext.Articles.Take(6).ToList();
            }
            return articles;
        }

        public List<Article> searchArticle(string keywords)
        {
            List<Article> articles = 
                databaseContext.Articles.Where(query => query.ArticleHead.Contains(keywords)).ToList();
            return articles;
        }
    }
}