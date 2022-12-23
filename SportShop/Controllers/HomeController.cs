using Microsoft.AspNetCore.Mvc;
using SportShop.Models;
using SportShop.Models.ViewModel;
using System.Diagnostics;

namespace SportShop.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index(string? category,int productPage = 1) =>
            View(new ProductListViewModel
            {
                Products = repository.Products.
                Where(p=>category==null||p.Category==category)
                .OrderBy(p => p.Id).
                Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage=PageSize,
                    TotalItems=repository.Products.Count(),
                },
                CurrentCategory=category
            });
    }
}