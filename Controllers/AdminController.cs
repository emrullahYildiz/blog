
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using blog.Interfaces;
using blog.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers{
    public class AdminController:Controller{
        private readonly IUser userContext;
        private readonly IComment commentContext;
        public AdminController(IUser userContext,IComment commentContext){
            this.userContext = userContext;
            this.commentContext = commentContext;
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
        /*Comment process start */

        [Authorize]
        public IActionResult Comments(){
            //passed data is last 10 comment
            //state = list
            ViewData["tableState"] = "list";
            //first time send last comments to view
            CommentsViewModel commentsViewModel = new CommentsViewModel{
                comments = commentContext.getLastComments()
            };
            return View(commentsViewModel);
        }

        //Comment search by article head
        [Authorize]
        [HttpPost]
        public IActionResult Comments(string articleHead){
            ViewData["tableState"] = "search";
            CommentsViewModel commentsViewModel = new CommentsViewModel{
                comments = commentContext.SearchCommentByArticleHead(articleHead)
            };
            return View(commentsViewModel);
        }

        [Authorize]
        [Route("/Admin/DeleteComment/{id?}")]
        public IActionResult DeleteComment(int id){
            commentContext.DeleteCommentById(id);
            return Redirect("/Admin/Comments");
        }

        /*Comment process end */
    }
}