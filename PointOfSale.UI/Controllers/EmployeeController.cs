using Microsoft.AspNetCore.Mvc;

namespace PointOfSale.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
