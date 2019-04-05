
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ArticleController:Controller{

        public IActionResult Index(){
            
            return View();
        }
    }
}