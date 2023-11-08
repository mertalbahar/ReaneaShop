using Entities.RequestParameters;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;


namespace ReaneaShopApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IServiceManager _manager;

        public ProductController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(ProductRequestParameters p)
        {
            var model = _manager.ProductService.GetAllProductsWithDetails(p);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            var model = _manager.ProductService.GetOneProduct(id, false);
            return View(model);
        }
    }
}