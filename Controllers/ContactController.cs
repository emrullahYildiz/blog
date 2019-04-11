
using blog.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ContactController:Controller{
        private readonly IContact contactContext;

        public ContactController(){
            this.contactContext = contactContext;
        }
        public IActionResult Index(IContact contactContex){

            return View();
        }

        [HttpPost]
        public IActionResult Index(string contactName,string contactMail,string contactMessage){
            contactContext.AddConctactMessage(contactName,contactMail,contactMessage);
            return View();
        }
    }
}