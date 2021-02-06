using DependencyInjection.Service;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View(_productService.All());
        }

        public IActionResult Method1()
        {
            _productService = new ProductService();
            return View(_productService.All());
        }

    }
}