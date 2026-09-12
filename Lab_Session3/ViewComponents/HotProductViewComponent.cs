using Lab_Session3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Session3.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        protected Product product = new Product();

        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();

            return View(products);
        }
    }
}