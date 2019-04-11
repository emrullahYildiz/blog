
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ArticleController:Controller{
        private readonly IArticle articleContext;
        private readonly ICategory categoryContext;
        private readonly IComment commentContext;
        public ArticleController(IArticle articleContext,ICategory categoryContext,IComment commentContext){
            this.articleContext = articleContext;
            this.categoryContext = categoryContext;
            this.commentContext = commentContext;
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
        /*Add comment form */
        [HttpPost]
        public IActionResult Index(string commentFullName,string commentMail,string commentContent,int articleId){
            commentContext.AddComment(commentFullName,commentMail,commentContent,articleId);
            return Redirect("/Article/Index/"+articleId);
        }
    }
}