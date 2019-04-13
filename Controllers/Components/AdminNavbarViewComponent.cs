

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class AdminNavbarViewComponent:ViewComponent{
        
        public async Task<IViewComponentResult> InvokeAsync(){

            return View();
        }
    }
}