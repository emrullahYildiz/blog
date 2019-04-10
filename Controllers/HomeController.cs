using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
using blog.Interfaces;

namespace blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategory categoryContext;
        private readonly IArticle articleContext;
        public HomeController(ICategory categoryContext,IArticle articleContext){
            this.categoryContext = categoryContext;
            this.articleContext = articleContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel{
                categories = categoryContext.getCategories(),
                articles = articleContext.getArticles(6),
                currentPageNumber = 0
            };
            return View(homeViewModel);
        }

        [HttpGet("/Home/Index/{page}")]
        public IActionResult Index(int page){
                HomeViewModel homeViewModel = new HomeViewModel{
                    categories = categoryContext.getCategories(),
                    articles = articleContext.getArticles(page,6),//to show 6 post, pass 6 post
                    currentPageNumber = page
                };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
