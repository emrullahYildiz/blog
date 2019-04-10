
using System.Threading.Tasks;
using blog.Interfaces;
using Microsoft.AspNetCore.Mvc;
using blog.Models;
namespace blog.Controllers{

    public class PaginationViewComponent:ViewComponent{
        private readonly IArticle articleContext;
        public PaginationViewComponent(IArticle articleContext){
            this.articleContext = articleContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(int currentPage){
            int articleCount = articleContext.getArticleCount();
            /* Calculation of next page */
            int nextPage = -1;// -1 mean next page is not avaible
            if(currentPage*6+6 < articleCount)
            {//every page has 6 post
                nextPage = currentPage + 1;
            }
            /*Calculation of most next page */
            int mostNextPage = -1;// -1 mean most next page is not avaible
            if(nextPage != -1)
            {//if next page is avaible
                mostNextPage = (int)((articleCount-6) / 6);//make sure not float number
            }
            /*Calculation of most previous page */
            int mostPreviousPage = 0; //Always 0
            /*Calculation of previous page */
            int previousPage = -1;//-1 mean no previous page
            if(currentPage != 0)//if current page is not first page
            {
                previousPage = currentPage - 1;
            }
            PaginationViewModel paginationViewModel = new PaginationViewModel{
                currentPageNumber = currentPage,
                nextPageNumber = nextPage,
                mostNextPageNumber = mostNextPage,
                previousPageNumber = previousPage,
                mostPreviousPageNumber = mostPreviousPage
            };
            return View(paginationViewModel);
        }
    }
}