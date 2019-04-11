
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ContactController:Controller{
        private readonly IContact contactContext;

        public ContactController(IContact contactContex,ICategory categoryContext){
            this.contactContext = contactContex;
        }
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(string contactName,string contactMail,string contactMessage){
            contactContext.AddConctactMessage(contactName,contactMail,contactMessage);
            return View();
        }
    }
}