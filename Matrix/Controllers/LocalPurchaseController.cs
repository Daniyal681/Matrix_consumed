using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class LocalPurchaseController : Controller
    {

        JSONResultResp resp = new JSONResultResp();
        private IRepositoryWrapper _repoWrapper;

        public LocalPurchaseController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<JsonResult> GetLocalPurchase()
        {
            try
            {
                List<GetLocalPurchase> localPurchases = await _repoWrapper.LocalPurchaseRepo.GetLocalPurchase();
                var jsonData = new
                {
                    draw = Request.Form["draw"].ToString(),
                    recordsFiltered = localPurchases.Count(),
                    recordsTotal = localPurchases.Count(),
                    data = localPurchases,
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
        public async Task<JsonResult> Add(LocalPurchaseRequest req)
        {
            try
            {
                if (req == null)
                    throw new Exception("Kindly enter local purchase name");
                else
                {
                    _repoWrapper.LocalPurchaseRepo.GenerateLocalPurchase(req);
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
        public async Task<IActionResult> EditModal(int RecID)
        {
            EditLocalPurchase localPurchase = new EditLocalPurchase();
            try
            {
                if (RecID >= 1)
                {
                    localPurchase = await _repoWrapper.LocalPurchaseRepo.GetLocalPurchase(RecID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", localPurchase);
        }

        public async Task<JsonResult> GetSupplierByID(int SupplierID)
        {
            try
            {
                return Json(new { hasError = false, response = await _repoWrapper.SupplierRepo.Getsupplier(SupplierID) });
            }
            catch (Exception ex)
            {
                return Json(new { hasError = true, error = ex.Message });
            }

        }
        public async Task<JsonResult> GetModelByID(int ModelID)
        {
            try
            {
                return Json(new { hasError = false, response = await _repoWrapper.ModelRepo.GetModel(ModelID) });
            }
            catch (Exception ex)
            {
                return Json(new { hasError = true, error = ex.Message });
            }
        } 
        public async Task<JsonResult> GetWarehouseByID(int WarehouseID)
        {
            try
            {
                return Json(new { hasError = false, response = await _repoWrapper.WareHouseRepo.GetWareHouse(WarehouseID) });
            }
            catch (Exception ex)
            {
                return Json(new { hasError = true, error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> Edit(EditLocalPurchase req)
        {
            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter local purchase name");
                }
                else
                {
                    await _repoWrapper.LocalPurchaseRepo.EditLocalPurchase(req);
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
