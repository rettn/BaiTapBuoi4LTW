using Lab_Session3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_Session3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Product products = new Product();
            DanhMuc danhmucs = new DanhMuc();

            ViewBag.DanhMuc = danhmucs.GetDanhMucs();

            return View(products.GetProductList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}