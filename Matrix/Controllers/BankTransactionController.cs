using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class BankTransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
