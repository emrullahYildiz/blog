
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class ContactController:Controller{
        private readonly IContact contactContext;
        private readonly ICategory categoryContext;

        public ContactController(IContact contactContex,ICategory categoryContext){
            this.contactContext = contactContex;
            this.categoryContext = categoryContext;
        }
        public IActionResult Index(IContact contactContex){
            ContactViewModel contactViewModel = new ContactViewModel{
                categories = categoryContext.getCategories()
            };
            return View(contactViewModel);
        }

        [HttpPost]
        public IActionResult Index(string contactName,string contactMail,string contactMessage){
            contactContext.AddConctactMessage(contactName,contactMail,contactMessage);
            ContactViewModel contactViewModel = new ContactViewModel{
                categories = categoryContext.getCategories()
            };
            return View(contactViewModel);
        }
    }
}