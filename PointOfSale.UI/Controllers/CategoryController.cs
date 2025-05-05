using Microsoft.AspNetCore.Mvc;

namespace PointOfSale.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
