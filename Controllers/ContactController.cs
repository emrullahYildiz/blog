
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ContactController:Controller{
        public IActionResult Index(){
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(string contactName,string contactMail,string contactMessage){

            return View()
        }
    }
}