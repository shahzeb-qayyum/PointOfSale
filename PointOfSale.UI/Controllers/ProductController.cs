using Microsoft.AspNetCore.Mvc;

namespace PointOfSale.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
