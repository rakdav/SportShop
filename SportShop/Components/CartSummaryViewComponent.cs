using Microsoft.AspNetCore.Mvc;
using SportShop.Models;

namespace SportShop.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cart)
        {
            this.cart = cart;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
