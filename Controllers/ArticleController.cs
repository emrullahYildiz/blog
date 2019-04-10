
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ArticleController:Controller{
        private readonly IArticle articleContext;
        private readonly ICategory categoryContext;
        public ArticleController(IArticle articleContext,ICategory categoryContext){
            this.articleContext = articleContext;
            this.categoryContext = categoryContext;
        }
        [HttpGet("/Article/Index/{articleId?}")]
        public IActionResult Index(int articleId)
        {
            ArticleIndexViewModel articleViewModel = new ArticleIndexViewModel{
                articleContent = articleContext.getArticleById(articleId),
                categories = categoryContext.getCategories()
            };
            return View(articleViewModel);
        }
    }
}