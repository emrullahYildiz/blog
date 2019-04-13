
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{

    public class AdminSidebarViewComponent:ViewComponent{
        public async Task<IViewComponentResult> InvokeAsync(){
            return View();
        }
    }
}