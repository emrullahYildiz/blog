
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using blog.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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
        /*Login process run here */
        [HttpPost]
        public async Task<IActionResult> Index(string username,string password){
            if(userContext.checkUser(username,password))//check user parameter
            {
                /*set User prop */
                var claims = new List<Claim>{
                    new Claim("user",username),
                    new Claim("role","admin")
                };
                /*Sign in */
                await HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies", "user", "role")));
                return Redirect("/Admin/Panel");
            }
            return View();
        }

        public async Task<IActionResult> Logout(){
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Panel");
        }

        
        [Authorize]
        public IActionResult Panel(){

            return View();
        }
    }
}