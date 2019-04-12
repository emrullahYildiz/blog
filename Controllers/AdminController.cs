
using blog.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class AdminController:Controller{
        private readonly IUser userContext;
        public AdminController(IUser userContext){
            this.userContext = userContext;
        }

        public IActionResult Index(){
            return View();
        }
    }
}