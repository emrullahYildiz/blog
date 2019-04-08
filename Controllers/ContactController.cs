
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ContactController:Controller{
        public IActionResult Index(){
            
            return View();
        }
    }
}