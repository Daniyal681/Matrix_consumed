using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
