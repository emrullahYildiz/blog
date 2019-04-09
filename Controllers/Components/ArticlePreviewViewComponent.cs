

using System.Threading.Tasks;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ArticlePreviewViewComponent:ViewComponent{
        
         public async Task<IViewComponentResult> InvokeAsync(Article articleData){

            return View(articleData);
        }
    }
}