using Microsoft.AspNetCore.Mvc;
using Services.Contracts;


namespace ReaneaShopApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            var orders = _manager.OrderService.Orders;
            return View(orders);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Complete([FromForm] int id)
        {
            _manager.OrderService.CompleteOrder(id);
            return RedirectToAction("Index");
        }
    }
}