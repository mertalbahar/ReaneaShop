using Microsoft.AspNetCore.Mvc;


namespace ReaneaShopApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}