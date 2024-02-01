using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class WareHouseController : Controller
    {
        JSONResultResp resp = new JSONResultResp();
        private IRepositoryWrapper _repoWrapper;

        public WareHouseController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<JsonResult> GetWarehouse()
        {
            try
            {
                List<GetWareHouse> wareHouses = await _repoWrapper.WareHouseRepo.GetWareHouse();
                var jsonData = new
                {
                    draw = Request.Form["draw"].ToString(),
                    recordsFiltered = wareHouses.Count(),
                    recordsTotal = wareHouses.Count(),
                    data = wareHouses,
                };

                return Json(jsonData);

            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);

        }

        [HttpPost]
        public async Task<JsonResult> Add(WareHouseDTO req)
        {
            JSONResultResp resp = new JSONResultResp();
            try
            {
                if (req == null)
                    throw new Exception("Kindly enter warehouse name");
                else
                {
                    _repoWrapper.WareHouseRepo.AddWareHouse(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }

        [HttpGet]
        public async Task<IActionResult> EditModal(int WareHouseID)
        {
            EditWarehouse wareHouse = new EditWarehouse();
            try
            {
                if (WareHouseID >= 1)
                {
                    wareHouse = await _repoWrapper.WareHouseRepo.GetWareHouse(WareHouseID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", wareHouse);
        }

        [HttpPost]
        public async Task<JsonResult> Edit(EditWarehouse req)
        {

            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter Warehouse name");
                }
                else
                {
                    await _repoWrapper.WareHouseRepo.EditWarehouse(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }
    }
}
