using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
