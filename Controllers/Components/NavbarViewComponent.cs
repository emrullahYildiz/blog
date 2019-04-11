
using System.Threading.Tasks;
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class NavbarViewComponent:ViewComponent{
        private readonly ICategory categoryContext;
        public NavbarViewComponent(ICategory categoryContext)
        {
            this.categoryContext = categoryContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(){

            NavbarViewModel navbarViewModel = new NavbarViewModel{
                categories = categoryContext.getCategories()
            };
            return View(navbarViewModel);
        }

    }
}