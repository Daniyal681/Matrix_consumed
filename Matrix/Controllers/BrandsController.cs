using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class BrandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
