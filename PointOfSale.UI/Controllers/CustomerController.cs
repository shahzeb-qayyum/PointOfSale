using Microsoft.AspNetCore.Mvc;

namespace PointOfSale.UI.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
