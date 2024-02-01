using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class CashManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
