using Core_Client.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using System.Diagnostics;

namespace Core_Client.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        ProductServiceClient client = new ProductServiceClient();

        public async Task<IActionResult> Index()
        {
            ViewBag.Products = await client.GetProductsAsync();
            return View();
        }

        //public IActionResult Index()
        //{
        //    ViewBag.Products = client.GetProductsAsync();
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}