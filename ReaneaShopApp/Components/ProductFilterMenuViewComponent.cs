using Microsoft.AspNetCore.Mvc;


namespace ReaneaShopApp.Components
{
    public class ProductFilterMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}