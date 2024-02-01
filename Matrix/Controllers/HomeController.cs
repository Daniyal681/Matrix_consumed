using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Matrix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Matrix.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        JSONResultResp resp = new JSONResultResp();

        public HomeController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Dashboard()
        {
            try
            {
                if (HttpContext.Session.GetString("MenuListData") != null)
                {
                    string storedData = HttpContext.Session.GetString("MenuListData");
                    return Json(storedData);
                }
               
                    List<MenuListDTO> menulist = await _repoWrapper.MenuListRepo.GetMenuLists();

                    HttpContext.Session.SetString("MenuListData", JsonConvert.SerializeObject(menulist));
                    return Json(menulist);
                
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}